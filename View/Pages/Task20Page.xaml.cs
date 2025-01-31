using System;
using System.Windows;
using System.Windows.Controls;
using ConsoleApp26.Classes;

namespace WpfApp6.View.Pages
{

    public partial class Task20Page : Page
    {
        public Task20Page()
        {
            InitializeComponent();
        }

        private void BtnTask20_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator20 calculator20 = new Calculator20(Convert.ToDouble(TbX.Text));

                MessageBox.Show($"{calculator20.CalculateA()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
            }
        }
    }
}
