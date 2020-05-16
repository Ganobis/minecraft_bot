using System;
using System.Windows;


namespace minecraft_bot
{
    /// <summary>
    /// Logika interakcji dla klasy ErrorWindow.xaml
    /// </summary>
    public partial class ErrorWindow : Window
    {
        public ErrorWindow()
        {
            InitializeComponent();
            textbox_error.Text = "Error:";
        }

        public void Inicialize_text(String text)
        {
            textbox_error.Text = "Error: " + text;
        }

        private void Clickbutton_error(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
