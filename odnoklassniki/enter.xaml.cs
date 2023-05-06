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

namespace odnoklassniki
{
    /// <summary>
    /// Логика взаимодействия для enter.xaml
    /// </summary>
    public partial class enter : Page
    {
         bool _IsTrue = true;
        public enter()
        {
            InitializeComponent();
        btncnt();
        }
        public void btncnt()
        {
            if (globalsvars.a == 1)
            {
                crORen.Content= "Войти";

            }
            else
            {
                _IsTrue=!_IsTrue;
/*                name.IsEnabled = _IsTrue;*/

                crORen.Content= "Создать";
            }
        }
        private void crORen_Click(object sender, RoutedEventArgs e)
        {


                if (globalsvars.a == 1)
                {
                    msg.UserName = name.Text;
                if (int.TryParse(port.Text, out int result))
                {

                    if (name.Text.Length < 4 || name.Text.Length > 25 || name.Text == "Lange" || name.Text == "Bibikin" || port.Text.Length != 4)
                    {
                        MessageBox.Show("Неверный формат строки.");
                    }
                    else
                    {
                        nameport.name = name.Text;
                        nameport.port = Convert.ToInt32(port.Text);
                        MainWindow server = new MainWindow();
                        entermain enter = new entermain();
                        server.Show();
                        enter.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неверно введён порт.");
                }
            }
            else if (globalsvars.a == 0)
            {
                msg.UserName = name.Text;
                if (int.TryParse(port.Text, out int result))
                {

                    if (name.Text.Length < 4 || name.Text.Length > 25 || name.Text == "Lange" || name.Text == "Bibikin" || port.Text.Length != 4)
                    {
                        MessageBox.Show("Неверный формат строки.");
                    }
                    else
                    {
                        nameport.name = name.Text;
                        nameport.port = Convert.ToInt32(port.Text);
                        MainWindow server = new MainWindow();
                        entermain enter = new entermain();
                        server.Show();
                        enter.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неверное введён порт.");
                }

                }
        }


    }
}
