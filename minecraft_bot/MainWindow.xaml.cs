using System;
using System.Drawing;
using System.Windows;


namespace minecraft_bot
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clickbutton_start_fishing(object sender, RoutedEventArgs e)
        {
            try
            {
                CaptureBox capturebox = new CaptureBox();
                capturebox.Show();
            }
            catch (Exception exception)
            {
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.Inicialize_text(exception.ToString());
                errorWindow.Show();
            }
        }

        private void Clickbutton_start_mine(object sender, RoutedEventArgs e)
        {

        }

        private void Clickbutton_exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
