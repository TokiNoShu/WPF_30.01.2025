using System;
using System.Windows;
using System.Windows.Controls;
using ConsoleApp26.Classes;

namespace WpfApp6.View.Pages
{

    public partial class Task30Page : Page
    {
        public Task30Page()
        {
            InitializeComponent();
        }

        private void BtnTask30_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator30 calculator30 = new Calculator30(Convert.ToDouble(TbX.Text));

                MessageBox.Show($"{calculator30.CalculateA()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
            }
        }
    }
}
