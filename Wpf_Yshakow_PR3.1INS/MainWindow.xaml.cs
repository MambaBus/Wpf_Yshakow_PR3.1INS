using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Yshakow_PR3._1INS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        float a, b;
        int x;

        private void bt1_Click_1(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text1.Text);
            x = 1;
            calculate();
        }

        private void bt19_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "0";
            text2.Text = "0";
            text3.Text = "0";
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text1.Text);
            x = 2;
            calculate();
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text1.Text);
            x = 3;
            calculate();
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text1.Text);
            x = 4;
            calculate();
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text1.Text);
            x = 5;
            calculate();
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text1.Text);
            x = 6;
            calculate();
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text2.Text);
            x = 7;
            calculate();
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text2.Text);
            x = 8;
            calculate();
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text2.Text);
            x = 9;
            calculate();
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text2.Text);
            x = 10;
            calculate();
        }

        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text2.Text);
            x = 11;
            calculate();
        }

        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text2.Text);
            x = 12;
            calculate();
        }

        private void bt13_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text3.Text);
            x = 13;
            calculate();
        }

        private void bt14_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text3.Text);
            x = 14;
            calculate();
        }

        private void bt15_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text3.Text);
            x = 15;
            calculate();
        }

        private void bt16_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text3.Text);
            x = 16;
            calculate();
        }

        private void bt17_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text3.Text);
            x = 17;
            calculate();
        }

        private void bt18_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text3.Text);
            x = 18;
            calculate();
        }

        private void calculate()
        {
            switch (x)
            {
                case 1:
                    b = a + 3;
                    text1.Text = b.ToString();
                    break;
                case 2:
                    b = a + 2;
                    text1.Text = b.ToString();
                    break;
                case 3:
                    b = a + 1;
                    text1.Text = b.ToString();
                    break;
                case 4:
                    b = a - 1;
                    text1.Text = b.ToString();
                    break;
                case 5:
                    b = a - 2;
                    text1.Text = b.ToString();
                    break;
                case 6:
                    b = a - 3;
                    text1.Text = b.ToString();
                    break;

                case 7:
                    b = a + 3;
                    text2.Text = b.ToString();
                    break;
                case 8:
                    b = a + 2;
                    text2.Text = b.ToString();
                    break;
                case 9:
                    b = a + 1;
                    text2.Text = b.ToString();
                    break;
                case 10:
                    b = a - 1;
                    text2.Text = b.ToString();
                    break;
                case 11:
                    b = a - 2;
                    text2.Text = b.ToString();
                    break;
                case 12:
                    b = a - 3;
                    text2.Text = b.ToString();
                    break;

                case 13:
                    b = a + 3;
                    text3.Text = b.ToString();
                    break;
                case 14:
                    b = a + 2;
                    text3.Text = b.ToString();
                    break;
                case 15:
                    b = a + 1;
                    text3.Text = b.ToString();
                    break;
                case 16:
                    b = a - 1;
                    text3.Text = b.ToString();
                    break;
                case 17:
                    b = a - 2;
                    text3.Text = b.ToString();
                    break;
                case 18:
                    b = a - 3;
                    text3.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
