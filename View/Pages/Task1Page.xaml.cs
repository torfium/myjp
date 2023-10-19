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
using System.Windows.Shapes;

namespace AAAAAAAAAAAA_SLOMALI.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();

        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"R = {3 * Math.Pow(Convert.ToDouble(TbT.Text), 2) + 3 * Math.Pow(Convert.ToDouble(TbL.Text), 2) + 4.9}");
        }
    }
}
