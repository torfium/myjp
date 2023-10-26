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
    /// Логика взаимодействия для Task307Page.xaml
    /// </summary>
    public partial class Task307Page : Page
    {
        public Task307Page()
        {
            InitializeComponent();
        }

        private void BtnAnswerA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"Значение y для x ({Convert.ToDouble(TbA.Text)}) = {2 * Math.Tan(Convert.ToDouble(TbA.Text))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Функция не определена для значения х");
            }
        }

        private void BtnAnswerB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show($"Значение y для x ({Convert.ToDouble(TbB.Text)}) = {3 / (Convert.ToDouble(TbB.Text) - 1)}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Функция не определена для значения х");
            }
        }
    }
}
