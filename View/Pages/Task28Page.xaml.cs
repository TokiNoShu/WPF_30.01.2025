using System;
using System.Windows;
using System.Windows.Controls;
using ConsoleApp26.Classes;

namespace WpfApp6.View.Pages
{

    public partial class Task28Page : Page
    {
        public Task28Page()
        {
            InitializeComponent();
        }

        private void BtnTask28_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator28 calculator28 = new Calculator28(Convert.ToDouble(TbX.Text));

                MessageBox.Show($"{calculator28.CalculateA()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
            }
        }
    }
}
