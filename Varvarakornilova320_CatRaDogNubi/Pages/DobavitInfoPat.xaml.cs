using System;
using Varvarakornilova320_CatRaDogNubi.DB;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using System.Windows.Media.Media3D;

namespace Varvarakornilova320_CatRaDogNubi.Pages
{
    /// <summary>
    /// Логика взаимодействия для DobavitInfoPat.xaml
    /// </summary>
    public partial class DobavitInfoPat : Page
    {
        public static List<Pet> pets { get; set; }
        public static List<User> users { get; set; }
        public static List<Information> info { get; set; }

        public DobavitInfoPat()
        {
            InitializeComponent();

            //users = new List<User>
            //    (Varvarakornilova320_CatRaDogNubi.DB.DbConnection.CatRaDogNubiEntities.User.ToList());
            pets = new List<Pet>
                (Varvarakornilova320_CatRaDogNubi.DB.DbConnection.CatRaDogNubiEntities.Pet.ToList());
            info = new List<Information>
                (Varvarakornilova320_CatRaDogNubi.DB.DbConnection.CatRaDogNubiEntities.Information.ToList());
            info.Insert(0, new Information() { ID_info = -1 });


            //var users = DbConnection.CatRaDogNubiEntities.User.ToList();
            //var user = users.FirstOrDefault(u => u.ID_user == 1);
            //if (users.Id == 1 )
            petinfo_list.ItemsSource = Varvarakornilova320_CatRaDogNubi.DB.DbConnection.CatRaDogNubiEntities.Information.ToList()/*.Where(i => i.ID_pet == 1)*/;


            this.DataContext = this;
        }

        private void dobavit_photo_btn_Click(object sender, RoutedEventArgs e)
        {
            Information info = new Information();

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpg|*.jpg|*.jpeg|*.jpeg"
            };

            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                info.Photo = File.ReadAllBytes(openFileDialog.FileName);

                var p = vibor_pet.SelectedItem as Pet;
                info.ID_pet = p.ID_pet;
                info.Description = vibor_op.Text.Trim();
                PhotoImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));

                DbConnection.CatRaDogNubiEntities.Information.Add(info);
                DbConnection.CatRaDogNubiEntities.SaveChanges();

                Refresh();
            }
        }

        private void Refresh()
        {
            petinfo_list.ItemsSource = Varvarakornilova320_CatRaDogNubi.DB.DbConnection.CatRaDogNubiEntities.Information.ToList();
        }

        private void obsh_photos_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.ObshPhotos());
        }
    }
}
