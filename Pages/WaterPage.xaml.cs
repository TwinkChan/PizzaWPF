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
    /// Логика взаимодействия для WaterPage.xaml
    /// </summary>
    public partial class WaterPage : Page
    {
        public double cost { get; set; }
        double w1;
        double w2;
        double w3;

        public WaterPage(double cost)
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ReceiptPage(cost));
        }

        private void AddFanta_Click(object sender, RoutedEventArgs e)
        {
            if (ColFanta.Text != null && ColFanta.Text != "")
            {
                w1 = Convert.ToDouble(ColFanta.Text);
                cost = 95 * w1;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым! Укажите числовое значение!", "Ошибка!", MessageBoxButton.OK);
            }
        }

        private void AddAqua_Click(object sender, RoutedEventArgs e)
        {
            if (ColAqua.Text != null && ColAqua.Text != "")
            {
                w2 = Convert.ToDouble(ColAqua.Text);
                cost = 55 * w2;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым! Укажите числовое значение!", "Ошибка!", MessageBoxButton.OK);
            }
        }

        private void AddTea_Click(object sender, RoutedEventArgs e)
        {
            if (ColTea.Text != null && ColTea.Text != "")
            {
                w3 = Convert.ToDouble(ColTea.Text);
                cost = 95 * w3;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым! Укажите числовое значение!", "Ошибка!", MessageBoxButton.OK);
            }
        }
    }
}
