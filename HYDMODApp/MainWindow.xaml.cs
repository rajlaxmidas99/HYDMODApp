using Microsoft.Win32;
using System.IO;
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

namespace HYDMODApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NewProject_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("New Project clicked");
            // TODO: Add logic to create a new project
        }

        private void OpenProject_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open Project clicked");
            // TODO: Add logic to open an existing project
        }

        private void SaveProject_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save Project clicked");
            // TODO: Add logic to save the current project
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void EditGeometry_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit Geometry clicked");
            // TODO: Open Geometry Editor
        }

        private void EditFlowData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit Flow Data clicked");
            // TODO: Open Flow Data Editor
        }

        private void EditBoundaryConditions_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit Boundary Conditions clicked");
            // TODO: Open BC Editor
        }

        private void RunSimulation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Run Simulation clicked");
            // TODO: Start Simulation
        }

        private void RunAnalysis_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Run Analysis clicked");
            // TODO: Run Analysis
        }

        private void ViewResults_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("View Results clicked");
            // TODO: Show Results
        }

        private void ViewGraphsTables_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("View Graphs and Tables clicked");
            // TODO: Show Graphs and Tables
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Settings clicked");
            // TODO: Open Settings Window
        }

        private void Preferences_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Preferences clicked");
            // TODO: Open Preferences Window
        }
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open button clicked (Toolbar)");
        }
    }
}