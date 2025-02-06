using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.TaskClasses;

namespace WpfApp6.View.Pages
{

    public partial class Task16Page : Page
    {
        public Task16Page()
        {
            InitializeComponent();
        }

        private void BtnTask16_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbY.Text) && string.IsNullOrEmpty(TbZ.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator16 calculator16 = new Calculator16(Convert.ToDouble(TbX.Text), Convert.ToDouble(TbY.Text), Convert.ToDouble(TbZ.Text));

                MessageBox.Show($"{calculator16.CalculateA()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
                TbY.Text = string.Empty;
                TbZ.Text = string.Empty;
            }
        }
    }
}
