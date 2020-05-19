using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace minecraft_bot
{
    /// <summary>
    /// Logika interakcji dla klasy ImageWindow.xaml
    /// </summary>
    public partial class ImageWindow : Window
    {
        private int height_ss, width_ss;
        private System.Windows.Point position;
        public ImageWindow()
        {
            InitializeComponent();
        }

        internal void Inicialize_image(Bitmap bitmap)
        {
            imagebox.Source = BitmapToImageSource(bitmap);
        }

        BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }

        private void Clickbutton_ok_imagewindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void TakeDimensions(System.Windows.Point position, int height, int width)
        {
            this.position = position;
            height_ss = height;
            width_ss = width;
        }
    }
}
