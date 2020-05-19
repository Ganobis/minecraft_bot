using System.Windows;
using System.Drawing;
using System;
using System.Windows.Input;
using System.Windows.Controls;

namespace minecraft_bot
{
    /// <summary>
    /// Logika interakcji dla klasy CaptureBox.xaml
    /// </summary>
    public partial class CaptureBox : Window
    {
        private System.Windows.Point position_press;
        private System.Windows.Point position_up;

        private bool is_ready;

        public CaptureBox()
        {
            InitializeComponent();
            is_ready = true;
        }


        private void Mouse_up(object sender, MouseButtonEventArgs e)
        {
            if (is_ready)
            {
                position_up = Mouse.GetPosition(this);

                if (position_press.X < position_up.X)
                    Canvas.SetLeft(canvas_rectangle, position_press.X);
                else
                    Canvas.SetLeft(canvas_rectangle, position_up.X);

                if (position_press.Y < position_up.Y)
                    Canvas.SetTop(canvas_rectangle, position_press.Y);
                else
                    Canvas.SetTop(canvas_rectangle, position_up.Y);

                canvas_rectangle.Width = Math.Abs(position_up.X - position_press.X);
                canvas_rectangle.Height = Math.Abs(position_up.Y - position_press.Y);
                canvas_rectangle.Visibility = Visibility.Visible;

                button_ok.Visibility = Visibility.Visible;
                button_retry.Visibility = Visibility.Visible;

                is_ready = false;
            }
        }

        private void Mouse_press(object sender, MouseButtonEventArgs e)
        {
            if (is_ready)
            {
                texbox_1.Visibility = Visibility.Hidden;
                position_press = Mouse.GetPosition(this);
            }
        }
        private void Clickbutton_ok(object sender, RoutedEventArgs e)
        {
            ImageWindow imageWindow = new ImageWindow();

            System.Windows.Point point;
            if(position_press.X < position_up.X)
            {
                if (position_press.Y < position_up.Y)
                    point = position_press;
                else
                    point = new System.Windows.Point(position_press.X, position_up.Y);
            }
            else
            {
                if (position_press.Y < position_up.Y)
                    point = new System.Windows.Point(position_up.X, position_press.Y);
                else
                    point = position_up;
            }
                

            imageWindow.TakeDimensions(point, (int)Math.Abs(position_press.Y - position_up.Y), (int)Math.Abs(position_up.X - position_press.X));
            this.Hide();
        }

        private void Clickbutton_retry(object sender, RoutedEventArgs e)
        {
            is_ready = true;
            canvas_rectangle.Visibility = Visibility.Hidden;
            button_ok.Visibility = Visibility.Hidden;
            button_retry.Visibility = Visibility.Hidden;
        }
    }
}
