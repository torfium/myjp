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
    /// Логика взаимодействия для Task1002Page.xaml
    /// </summary>
    public partial class Task1002Page : Page
    {
        public Task1002Page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;

            int result = RomanToDecimal(input);
            MessageBox.Show("Результат: " + result);
        }

        private int RomanToDecimal(string romanNumber)
        {
            int decimalNumber = 0;

            for (int i = 0; i < romanNumber.Length; i++)
            {
                if (i + 1 < romanNumber.Length && RomanSymbolToDecimal(romanNumber[i]) < RomanSymbolToDecimal(romanNumber[i + 1]))
                {
                    decimalNumber -= RomanSymbolToDecimal(romanNumber[i]);
                }
                else
                {
                    decimalNumber += RomanSymbolToDecimal(romanNumber[i]);
                }
            }

            return decimalNumber;
        }

        private int RomanSymbolToDecimal(char symbol)
        {
            switch (symbol)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    throw new ArgumentOutOfRangeException("symbol", "Неверный символ");
            }
        }
    }
}
