using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ArtivaatEditor.GameProject
{
    /// <summary>
    /// Interaction logic for ProjectBrowserDialog.xaml
    /// </summary>
    public partial class ProjectBrowserDialog : Window
    {
        public ProjectBrowserDialog()
        {
            InitializeComponent();
        }

        private void OnToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender == openProjectButton)
            {
                openProjectButton.IsChecked = true;
                createProjectButton.IsChecked = false;

                OpenProjectView.Visibility = Visibility.Visible;
                CreateProjectView.Visibility = Visibility.Collapsed;
            }
            else
            {
                createProjectButton.IsChecked = true;
                openProjectButton.IsChecked = false;

                OpenProjectView.Visibility = Visibility.Collapsed;
                CreateProjectView.Visibility = Visibility.Visible;
            }
        }
    }
}
