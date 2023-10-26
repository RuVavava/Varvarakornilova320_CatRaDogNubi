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
    /// Логика взаимодействия для DobavitInfoPat.xaml
    /// </summary>
    public partial class DobavitInfoPat : Page
    {
        public static List<Pet> pets { get; set; }
        public DobavitInfoPat()
        {
            InitializeComponent();
            pets = new List<Pet>
                (Varvarakornilova320_CatRaDogNubi.DB.DbConnection.CatRaDogNubiEntities.Pet.ToList());
            this.DataContext = this;
        }
    }
}
