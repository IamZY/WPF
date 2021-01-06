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

namespace L003
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Window win;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            win = new Window1();
            win.Show();
            //win.ShowDialog();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            win.Hide();
        }
    }
}
