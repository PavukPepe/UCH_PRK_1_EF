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
using PRACT_LAB_1_DS.VOD_DSTableAdapters;

namespace PRACT_LAB_1_DS
{
    /// <summary>
    /// Логика взаимодействия для Employeers_page.xaml
    /// </summary>
    public partial class Employeers_page : Page
    {
        EmployeersTableAdapter employeers = new EmployeersTableAdapter();
        public Employeers_page()
        {
            InitializeComponent();
            Table.ItemsSource = employeers.GetData();
        }
    }
}
