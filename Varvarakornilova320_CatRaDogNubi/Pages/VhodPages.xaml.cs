using System;
using Varvarakornilova320_CatRaDogNubi.DB;
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

namespace Varvarakornilova320_CatRaDogNubi.Pages
{
    /// <summary>
    /// Логика взаимодействия для VhodPages.xaml
    /// </summary>
    public partial class VhodPages : Page
    {
        public static List<User> users { get; set; }
        public VhodPages()
        {
            InitializeComponent();
        }

        private void vhod_btn_Click(object sender, RoutedEventArgs e)
        {
            string login = Convert.ToString(login_tb.Text.Trim());
            string password = Convert.ToString(passoword_tb.Text.Trim());

            var users = DbConnection.CatRaDogNubiEntities.User.ToList();
            var user = users.FirstOrDefault(u => u.Login_user == login && u.Password_user == password);
            if (user != null && user.ID_user ==1)
            {
                MessageBox.Show($"Добро пожаловать! {user.Name_user}");
                NavigationService.Navigate(new Pages.DobavitInfoPat());
            }
            else if (user != null && user.ID_user == 2)
            {
                MessageBox.Show($"Добро пожаловать! {user.Name_user}");
                NavigationService.Navigate(new Pages.DobavitInfoPat());
            }
            else
                MessageBox.Show("Введенные данные некорректны!");
        }
    }
}
