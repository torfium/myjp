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
    /// Логика взаимодействия для Taks15Page.xaml
    /// </summary>
    public partial class Task15Page : Page
    {
        public Task15Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"H = {Math.Sin(Math.Pow(Convert.ToDouble(TbY.Text), 2)) - 2.8 * Convert.ToDouble(TbY.Text) + Math.Abs(Math.Sqrt(Convert.ToDouble(TbY.Text)))}");
        }
    }
}
