using System;
using System.Windows;
using System.Windows.Controls;
using ConsoleApp26.Classes;


namespace WpfApp6.View.Pages
{

    public partial class Task26Page : Page
    {
        public Task26Page()
        {
            InitializeComponent();
        }

        private void BtnTask26_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbY.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator26 calculator26 = new Calculator26(Convert.ToDouble(TbX.Text), Convert.ToDouble(TbY.Text));

                MessageBox.Show($"{calculator26.CalculateA()};\n{calculator26.CalculateB()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}
