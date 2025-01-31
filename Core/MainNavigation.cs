using System;
using System.Windows;
using System.Windows.Controls;
using ConsoleApp26.Classes;
using WpfApp6.View.Pages;

namespace WpfApp6.Core
{
    public static class MainNavigation
    {
        public static Frame MainFrameNav { get; set; }
    }
    public class SwitchToTask
    {
        readonly private int _sw;


        public SwitchToTask(int sw)
        {
            _sw = sw;
        }
        public void SwitchTask()
        {
            bool a, b, c, x, y, z;
            switch (_sw)
            {
                case 1:
                    a = true;
                    b = false;
                    c = false;

                    Calculator1 calculator1 = new Calculator1(a, b, c);
                    MessageBox.Show($"{calculator1.CalculateA()};\n{calculator1.CalculateB()};\n{calculator1.CalculateC()}",  "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 2:
                    x = false;
                    y = true;
                    z = false;

                    Calculator2 calculator2 = new Calculator2(x, y, z);
                    MessageBox.Show($"{calculator2.CalculateA()};\n{calculator2.CalculateB()}; \n{calculator2.CalculateC()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 3:
                    double x31 = 1;
                    double y31 = 2;
                    double x32 = 2;
                    double y32 = -2;

                    Calculator3 calculator3 = new Calculator3(x31, y31, x32, y32);
                    MessageBox.Show($"{calculator3.CalculateA()};\n{calculator3.CalculateB()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 4:
                     MainNavigation.MainFrameNav.Navigate(new Task4Page());
                    break;

                case 5:
                    MainNavigation.MainFrameNav.Navigate(new Task5Page());
                    break;

                case 6:
                    x = false;
                    y = false;
                    z = true;

                    Calculator6 calculator6 = new Calculator6(x, y, z);
                    MessageBox.Show($"{calculator6.CalculateA()};\n{calculator6.CalculateB()}\n{calculator6.CalculateC()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 7:
                    MainNavigation.MainFrameNav.Navigate(new Task7Page());
                    break;

                case 8:
                    double x81 = 1;
                    double y81 = 2;
                    double x82 = 2;
                    double y82 = 1;

                    Calculator8 calculator8 = new Calculator8(x81, y81, x82, y82);
                    MessageBox.Show($"{calculator8.CalculateA()};\n{calculator8.CalculateB()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 9:
                    double x91 = 1;
                    double y91 = 2;
                    double x92 = 2;
                    double y92 = 1;

                    Calculator9 calculator9 = new Calculator9(x91, y91, x92, y92);
                    MessageBox.Show($"{calculator9.CalculateA()};\n{calculator9.CalculateB()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 10:
                    a = true;
                    b = false;
                    c = true;

                    Calculator10 calculator10 = new Calculator10(a, b, c);
                    MessageBox.Show($"{calculator10.CalculateA()};\n{calculator10.CalculateB()}\n{calculator10.CalculateC()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 11:
                    double x111 = 1;
                    double y111 = 2;
                    double x112 = 2;
                    double y112 = 1;

                    Calculator11 calculator11 = new Calculator11(x111, y111, x112, y112);
                    MessageBox.Show($"{calculator11.CalculateA()};\n{calculator11.CalculateB()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 12:
                    MainNavigation.MainFrameNav.Navigate(new Task12Page());
                    break;

                case 13:
                    MainNavigation.MainFrameNav.Navigate(new Task13Page());
                    break;

                case 14:
                    MainNavigation.MainFrameNav.Navigate(new Task14Page());
                    break;

                case 15:
                    MainNavigation.MainFrameNav.Navigate(new Task15Page());
                    break;

                case 16:
                    MainNavigation.MainFrameNav.Navigate(new Task16Page());
                    break;

                case 17:
                    MainNavigation.MainFrameNav.Navigate(new Task5Page());
                    break;

                case 18:
                    a = true;
                    b = false;
                    c = false;

                    Calculator18 calculator18 = new Calculator18(a, b, c);
                    MessageBox.Show($"{calculator18.CalculateA()};\n{calculator18.CalculateB()},\n{calculator18.CalculateC()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 19:
                    a = false;
                    b = false;
                    c = true;

                    Calculator19 calculator19 = new Calculator19(a, b, c);
                    MessageBox.Show($"{calculator19.CalculateA()};\n{calculator19.CalculateB()},\n{calculator19.CalculateC()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 20:
                    MainNavigation.MainFrameNav.Navigate(new Task20Page());
                    break;

                case 21:
                    x = false;
                    y = false;
                    z = true;

                    Calculator21 calculator21 = new Calculator21(x, y, z);
                    MessageBox.Show($"{calculator21.CalculateA()};\n{calculator21.CalculateB()},\n{calculator21.CalculateC()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;

                case 22:
                    MainNavigation.MainFrameNav.Navigate(new Task22Page());
                    break;

                case 23:
                    MainNavigation.MainFrameNav.Navigate(new Task23Page());
                    break;

                case 24:
                    MainNavigation.MainFrameNav.Navigate(new Task24Page());
                    break;

                case 25:
                    MainNavigation.MainFrameNav.Navigate(new Task25Page());
                    break;

                case 26:
                    MainNavigation.MainFrameNav.Navigate(new Task26Page());
                    break;

                case 27:
                    MainNavigation.MainFrameNav.Navigate(new Task27Page());
                    break;

                case 28:
                    MainNavigation.MainFrameNav.Navigate(new Task28Page());
                    break;

                case 29:
                    MainNavigation.MainFrameNav.Navigate(new Task29Page());
                    break;

                case 30:
                    MainNavigation.MainFrameNav.Navigate(new Task30Page());
                    break;
            }
        }
    }
}