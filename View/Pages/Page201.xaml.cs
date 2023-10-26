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
    /// Логика взаимодействия для Window201.xaml
    /// </summary>
    public partial class Page201 : Page
    {
        public Page201()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            //1
            try
            {
                MessageBox.Show($"G = {(Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(TbF.Text))) / (Math.Log(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(TbF.Text)))}");
            }
            catch (Exception)
            {
                MessageBox.Show($"Неправильно! Попробуй ещё раз!");
            }
            
            
        }
    }
}
