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

namespace RMA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void ok_Click(object sender, RoutedEventArgs e)
        {
           if ( login_1.Text == string.Empty)
            { 

            TextBlock tb = new TextBlock();
            tb.Text = "Hello World!" ;
            MessageBox.Show("Hello, world.");
            }
           else
            {
                MessageBox.Show("Привет,"+login_1.Text  );
            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Confg_con_Click(object sender, RoutedEventArgs e)
        {
            Conf_conn con = new Conf_conn();
            con.Show();
        }
    }

   
}
