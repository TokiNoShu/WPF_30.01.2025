using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.TaskClasses;


namespace WpfApp6.View.Pages
{

    public partial class Task22Page : Page
    {
        public Task22Page()
        {
            InitializeComponent();
        }

        private void BtnTask22_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbY.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator22 calculator22 = new Calculator22(Convert.ToDouble(TbX.Text), Convert.ToDouble(TbY.Text));

                MessageBox.Show($"{calculator22.CalculateA()};\n{calculator22.CalculateB()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}
