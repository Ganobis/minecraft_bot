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

        private void CaptureScreen()
        {
            try
            {
                CaptureBox capturebox = new CaptureBox();
                capturebox.Show();

                Bitmap bitmap = new Bitmap(600, 400);
                Graphics g = Graphics.FromImage(bitmap);

                textbox_fishing.Text = bitmap.Size.ToString();


                //g.CopyFromScreen(position.Item1, position.Item2, 0, 0, bitmap.Size);

                ImageWindow imageWindow = new ImageWindow();
                imageWindow.inicialize_image(bitmap);
                imageWindow.Show();
            }
            catch(Exception exception)
            {
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.inicialize_text(exception.ToString());
                errorWindow.Show();
            }

        }

        private void clickbutton_start_fishing(object sender, RoutedEventArgs e)
        {
            CaptureScreen();
        }
    }
}
