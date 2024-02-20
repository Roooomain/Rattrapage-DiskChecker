using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Controls;
using LiveCharts.Wpf;
using LiveCharts;
using DiskCheckerWPF.Helper;

namespace DiskCheckerWPF.Views
{
    /// <summary>
    /// Logique d'interaction pour Home.xaml
    /// </summary>
    public partial class Home : Page, IObserver
    {
        private static readonly Home _instance = new Home();
        public static Home Instance
        {
            get { return _instance; }
        }
        
        public SeriesCollection PieSeriesCollection { get; set; }
        public string TotalSpaceText { get; set; }
        public string FreeSpaceText { get; set; }
        public string Interval { get; set; }
        
        private Home()
        {
            InitializeComponent();
            InitializeChart();
        }
        
        private void btnUpdateInterval_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtInterval.Text, out int interval) && interval > 0)
            {
                DiskCheckerMonitoring.Instance.UpdateInterval(interval);
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer for the interval.");
            }
        }
        
        public void Update(DiskCheckerInfo info)
        {
            Dispatcher.Invoke(() =>
            {
                PieSeriesCollection[0].Values = new ChartValues<double> { info.FreeSpace };
                PieSeriesCollection[1].Values = new ChartValues<double> { (info.TotalSpace - info.FreeSpace) };
                runFreeSpace.Text = info.FreeSpace.ToString();
                runTotalSpace.Text = info.TotalSpace.ToString();
                runInterval.Text = info.Interval.ToString();
            });
        }
        
        private void InitializeChart()
        {
            PieSeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Libre",
                    Values = new ChartValues<double> {0},
                    DataLabels = true
                },

                new PieSeries
                {
                    Title = "Utilisé",
                    Values = new ChartValues<double> {0},
                    DataLabels = true
                }
            };
            
            DataContext = this;
        }
    }
}

