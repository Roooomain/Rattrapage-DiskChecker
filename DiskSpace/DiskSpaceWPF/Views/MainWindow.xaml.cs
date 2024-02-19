﻿using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace DiskSpaceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            var monitor = DiskSpaceMonitor.Instance;
            var logger = DiskSpaceLogger.Instance;
            var home = Views.Home.Instance;
            monitor.Attach(logger);
            monitor.Attach(home);
            monitor.CheckDiskSpace();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            NavigateToHomeView();
        }

        private void NavigateToHomeView()
        {
            navframe.Navigate(Views.Home.Instance);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        { 
            NavigateToHomeView();
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Construire le chemin complet vers le fichier log
                var logFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "logDiskSpace.log");

                // Vérifier si le fichier log existe
                if (System.IO.File.Exists(logFilePath))
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "notepad.exe", // Utiliser Notepad pour ouvrir le fichier
                        Arguments = logFilePath, // Passer le chemin du fichier comme argument
                        UseShellExecute = true,
                        WindowStyle = ProcessWindowStyle.Normal,
                    };

                    Process.Start(psi);
                }
                else
                {
                    // Optionnellement, afficher un message si le fichier n'existe pas
                    MessageBox.Show("Le fichier log n'existe pas.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                // Optionnellement, gérer l'exception, par exemple afficher un message d'erreur
                MessageBox.Show($"Une erreur est survenue: {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}