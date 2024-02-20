using System.Diagnostics;
using System.Windows;

namespace DiskCheckerWPF
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
            
            // Initialiser le monitoring
            var monitoring = DiskCheckerMonitoring.Instance;
            var logger = DiskCheckerLogger.Instance;
            var home = Views.Home.Instance;
            
            // Attacher les observateurs (design pattern Observer)
            monitoring.Attach(logger);
            monitoring.Attach(home);
            monitoring.CheckDisk();
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
                // Chemin du fichier log
                var logFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "logDiskChecker.log");

                // Vérifier si le fichier log existe
                if (System.IO.File.Exists(logFilePath))
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "notepad.exe", // Utiliser Notepad pour ouvrir le fichier
                        Arguments = logFilePath, // Passer le chemin du fichier comme argument
                        UseShellExecute = true, // Utiliser le shell pour démarrer le processus
                        WindowStyle = ProcessWindowStyle.Normal,// Afficher la fenêtre de Notepad
                    };

                    Process.Start(psi);
                }
                else
                {
                    // Afficher un message si le fichier log n'existe pas
                    MessageBox.Show("Le fichier log n'existe pas.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                // Afficher un message si une erreur survient
                MessageBox.Show($"Une erreur est survenue: {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}