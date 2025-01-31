using System;
using System.Windows;
using System.Windows.Controls;
using ConsoleApp26.Classes;

namespace WpfApp6.View.Pages
{

    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator5 calculator5 = new Calculator5(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));

                MessageBox.Show($"{calculator5.CalculateA()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbB.Text = string.Empty;
                TbA.Text = string.Empty;
            }
        }
    }
}
