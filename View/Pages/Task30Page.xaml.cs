using System;
using System.Windows;
using System.Windows.Controls;

namespace AAAAAAAAAAAA_SLOMALI.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task30Page.xaml
    /// </summary>
    public partial class Task30Page : Page
    {
        public Task30Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Короче W= {Math.Exp(Convert.ToDouble(TbY.Text) + Convert.ToDouble(TbR.Text)) + 7.2 * Math.Sin(Convert.ToDouble(TbR.Text))}");
        }
    }
}
