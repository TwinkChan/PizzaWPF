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

namespace Pizza.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public double cost { get; set; }
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ButtonFood_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FoodPage(cost));
        }

        private void ButtonReference_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReferencePage());
        }

        private void ButtonBeverages_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WaterPage(cost));
        }

        private void ButtonReceipt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReceiptPage(cost));
        }
    }
}
