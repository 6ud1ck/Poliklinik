using Poliklinik.DB;
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

namespace Poliklinik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            get();
        }

        public void get()
        {
            List<Add> list = new List<Add>();
            LvKlinik.ItemsSource = EFClass.entities.Add.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
