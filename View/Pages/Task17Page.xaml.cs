using System;
using System.Windows;
using System.Windows.Controls;
using ConsoleApp26.Classes;

namespace WpfApp6.View.Pages
{

    public partial class Task17Page : Page
    {
        public Task17Page()
        {
            InitializeComponent();
        }

        private void BtnTask17_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(TbZ.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator17 calculator17 = new Calculator17(Convert.ToDouble(TbX.Text), Convert.ToDouble(TbY.Text), Convert.ToDouble(TbZ.Text));

                MessageBox.Show($"{calculator17.CalculateA()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
                TbY.Text = string.Empty;
                TbZ.Text = string.Empty;
            }
        }
    }
}
