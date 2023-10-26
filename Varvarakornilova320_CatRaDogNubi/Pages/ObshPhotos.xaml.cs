﻿using System;
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
using Varvarakornilova320_CatRaDogNubi.DB;

namespace Varvarakornilova320_CatRaDogNubi.Pages
{
    /// <summary>
    /// Логика взаимодействия для ObshPhotos.xaml
    /// </summary>
    public partial class ObshPhotos : Page
    {
        public static List<Pet> pets { get; set; }
        public static List<Information> info { get; set; }
        public ObshPhotos()
        {
            InitializeComponent();
            pets = new List<Pet>
                (Varvarakornilova320_CatRaDogNubi.DB.DbConnection.CatRaDogNubiEntities.Pet.ToList());
            info = new List<Information>
                (Varvarakornilova320_CatRaDogNubi.DB.DbConnection.CatRaDogNubiEntities.Information.ToList());
            info.Insert(0, new Information() { ID_info = -1 });

            obsh_list.ItemsSource = Varvarakornilova320_CatRaDogNubi.DB.DbConnection.CatRaDogNubiEntities.Information.ToList()/*.Where(i => i.ID_pet == 1)*/;
            this.DataContext = this;
        }
    }
}
