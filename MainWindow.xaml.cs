using System;
using System.Windows;
using User_Interface.views;

namespace ButtonBugExample
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Show the dialog
                var dialog = new Auto_Populate_Popup(null);
                if (dialog.ShowDialog() == true)
                    MessageBox.Show("Clicked OK");
                else
                    MessageBox.Show("Clicked Cancel");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
