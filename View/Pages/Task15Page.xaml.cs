using System;
using System.Windows;
using System.Windows.Controls;
using ConsoleApp26.Classes;

namespace WpfApp6.View.Pages
{

    public partial class Task15Page : Page
    {
        public Task15Page()
        {
            InitializeComponent();
        }

        private void BtnTask15_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator15 myTask15Class = new Calculator15(Convert.ToDouble(TbA.Text));

                MessageBox.Show($"{myTask15Class.CalculateA()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
            }
        }
    }
}
