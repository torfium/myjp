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
    /// Логика взаимодействия для Task16Page.xaml
    /// </summary>
    public partial class Task16Page : Page
    {
        public Task16Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"S = {Math.Sqrt(4 * Math.Pow(Convert.ToDouble(TbY.Text), 2) + 7.151)}");
        }
    }
}
