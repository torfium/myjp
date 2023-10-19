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
    /// Логика взаимодействия для Task19Page.xaml
    /// </summary>
    public partial class Task19Page : Page
    {
        public Task19Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            MessageBox.Show($"P = {Convert.ToDouble(TbN.Text) * Math.Sqrt(Math.Pow(Convert.ToDouble(TbY), 3) + 1.09 * Convert.ToDouble(TbG.Text))}");

            }
            catch (Exception)
            {

                MessageBox.Show($"Неправильно, попробуй ещё раз!");
            }

        }
    }
}
