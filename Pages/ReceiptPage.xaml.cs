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
    /// Логика взаимодействия для ReceiptPage.xaml
    /// </summary>
    public partial class ReceiptPage : Page
    {
        double result;
        public double cost { get; set; }

        public ReceiptPage(double cost)
        {
            InitializeComponent();
            SummAll.Text = Convert.ToString(cost);
        }

        private void ProcDiscount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ProcDiscount.Text != null && ProcDiscount.Text != "")
            {
                result = Convert.ToDouble(ProcDiscount.Text);
                SummDiscount.Text = Convert.ToString(result);
            }
            else
            {
                MessageBox.Show("Поле не может быть пустым! Укажите числовое значение!", "Ошибка!", MessageBoxButton.OK);
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ButtonBuy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ожидайте заказ!", "Ожидание", MessageBoxButton.OK);
        }
    }
}
