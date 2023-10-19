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

namespace AAAAAAAAAAAA_SLOMALI.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                MessageBox.Show($"D = {9.8 * Math.Pow(Convert.ToDouble(TbA.Text), 2) + 5.22 * Math.Cos(Math.Pow(Convert.ToDouble(TbT.Text), 5))}");
            }
            catch (Exception)
            {

                MessageBox.Show($"Неправильно, попробуй ещё раз!");
            }
        }
    }
}
