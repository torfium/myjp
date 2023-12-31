﻿using System;
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
    /// Логика взаимодействия для Task1001Page.xaml
    /// </summary>
    public partial class Task1001Page : Page
    {
        public Task1001Page()
        {
            InitializeComponent();
        }
        private void SwapButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i += 2)
            {
                if (i + 1 < words.Length)
                {
                    string temp = words[i];
                    words[i] = words[i + 1];
                    words[i + 1] = temp;
                }
            }

            string result = string.Join(" ", words);
            resultTextBlock.Text = result;
        }
    }
}
