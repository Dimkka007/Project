using System;
using System.Collections.Generic;
using System.Data;
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


namespace YP
{
    /// <summary>
    /// Логика взаимодействия для Vhod.xaml
    /// </summary>
    public partial class Vhod : Page
    {
        
        public Vhod()
        {
            InitializeComponent();
           
        }

        private void EnterVhod(object sender, RoutedEventArgs e)
        {
            YPEntities dimka = new YPEntities();
            Vhod autohorization = new Vhod();
            var user = dimka.Agent.FirstOrDefault(x => x.Email == Email.Text && x.Password == Password.Text);
            if(user == null)
            {
                MessageBox.Show("Пароль не верный");

            }
            else
            {
                Manager.MainFrame.Navigate(new Vse());
                MessageBox.Show("Здравствуйте! " + user.Title);
            }
        }
    }
}
