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
using System.Windows.Shapes;

namespace odnoklassniki
{
    /// <summary>
    /// Логика взаимодействия для entermain.xaml
    /// </summary>
    public partial class entermain : Window
    {
        public int a = 0;
        public entermain()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
           globalsvars.a = 1;
            frame.Content = new enter();
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            globalsvars.a = 0;
            frame.Content = new enter();
        }
    }
}
