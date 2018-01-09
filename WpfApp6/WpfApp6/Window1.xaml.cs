using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Window1.xaml 的互動邏輯
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public InkCanvas mydraw; 
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Blue;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Orange;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Red;
            da.Width = 15;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Purple;
            da.Width = 20;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Yellow;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Green;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Gray;
            da.Width = 25;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Black;
            da.Width = 10;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.DarkBlue;
            da.Width = 5;
            mydraw.DefaultDrawingAttributes = da;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            DrawingAttributes da = new DrawingAttributes();
            da.Color = Colors.Pink;
            da.Width = 3;
            mydraw.DefaultDrawingAttributes = da;
        }
    }
}
