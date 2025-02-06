using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp6.TaskClasses;


namespace WpfApp6.View.Pages
{

    public partial class Task27Page : Page
    {
        public Task27Page()
        {
            InitializeComponent();
        }

        private void BtnTask27_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbX.Text) && string.IsNullOrEmpty(TbY.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator27 calculator27 = new Calculator27(Convert.ToDouble(TbX.Text), Convert.ToDouble(TbY.Text));

                MessageBox.Show($"{calculator27.CalculateA()};\n{calculator27.CalculateB()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbX.Text = string.Empty;
                TbY.Text = string.Empty;
            }
        }
    }
}
