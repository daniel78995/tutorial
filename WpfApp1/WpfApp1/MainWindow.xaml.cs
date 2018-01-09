using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String name = textBox1.Text;
            String phone = textBox2.Text;
            textBox1.Text = " ";
            textBox2.Text = " ";
            TextBlock tb = new TextBlock();
            tb.Inlines.Add(new Bold(new Run(name)));
            tb.Inlines.Add(new Italic(new Run(phone)));

            stackPanell.Children.Add(tb);
        }
    }
}
