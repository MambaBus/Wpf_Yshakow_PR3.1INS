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

            text1.Text = "0";
            text2.Text = "0";
            text3.Text = "0";
        }

        float a, b;
        int count;

        private void bt1_Click_1(object sender, RoutedEventArgs e)
        {
            a = float.Parse(text1.Text);
            count = 1;
            calculate();
        }

        private void bt19_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
        }

        private void calculate()
        {
        }
    }
}
