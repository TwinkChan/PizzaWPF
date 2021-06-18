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
    /// Логика взаимодействия для FoodPage.xaml
    /// </summary>
    public partial class FoodPage : Page
    {

        double t1;
        double t2;
        double t3;
        public double cost { get; set; }

        public FoodPage(double cost)
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WaterPage(cost));
        }

        private void AddPipironi_Click(object sender, RoutedEventArgs e)
        {
            if (ColPipironi.Text != null && ColPipironi.Text != "")
            {
                t1 = Convert.ToDouble(ColPipironi.Text);
                cost = 395 * t1;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым! Укажите числовое значение!", "Ошибка!", MessageBoxButton.OK);
            }
        }

        private void AddMechico_Click(object sender, RoutedEventArgs e)
        {
            if (ColMechico.Text != null && ColMechico.Text != "")
            {
                t2 = Convert.ToDouble(ColMechico.Text);
                cost = 445 * t2;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым! Укажите числовое значение!", "Ошибка!", MessageBoxButton.OK);
            }
        }

        private void AddChicken_Click(object sender, RoutedEventArgs e)
        {
            if (ColChicken.Text != null && ColChicken.Text != "")
            {
                t3 = Convert.ToDouble(ColChicken.Text);
                cost = 295 * t3;
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым! Укажите числовое значение!", "Ошибка!", MessageBoxButton.OK);
            }
        }
    }
}
