using System.Windows;
using System.Drawing;
using System;
using System.Windows.Input;
using System.Windows.Controls;
using System.Threading;

namespace minecraft_bot
{
    /// <summary>
    /// Logika interakcji dla klasy CaptureBox.xaml
    /// </summary>
    public partial class CaptureBox : Window
    {
        private System.Windows.Point position_press;
        private System.Windows.Point position_up;

        public CaptureBox()
        {
            InitializeComponent();
        }


        private void mouse_up(object sender, MouseButtonEventArgs e)
        {
            position_up = Mouse.GetPosition(this);

            if (position_press.X < position_up.X)
                Canvas.SetLeft(canvas_rectangle ,position_press.X);
            else
                Canvas.SetLeft(canvas_rectangle, position_up.X);

            if (position_press.Y < position_up.Y)
                Canvas.SetTop(canvas_rectangle, position_press.Y);
            else
                Canvas.SetTop(canvas_rectangle, position_up.Y);

            canvas_rectangle.Width = Math.Abs(position_up.X - position_press.X);
            canvas_rectangle.Height = Math.Abs(position_up.Y - position_press.Y);
        }

        private void mouse_press(object sender, MouseButtonEventArgs e) => position_press = Mouse.GetPosition(this);
    }
}
