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

namespace Wpf_Crafton
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
        private void Schet_Click(object dender, RoutedEventArgs e)
        {
            //Считывание начальный данных

            double x0 = Convert.ToDouble(X0.Text);
            double xk = Convert.ToDouble(Xk.Text);
            double dx = Convert.ToDouble(Dx.Text);
            double a = Convert.ToDouble(A.Text);

            // Цикл для табулирования функции

            double x = x0;

            while (x <= (xk + dx / 2))
            {

                double y = a * Math.Log(x);

                x.Text += "x=" = Convert.ToString(x) + Environment.NewLine;
                y.Text += "y=" = Convert.ToString(y) + Environment.NewLine;

                x = x + dx;
            }
        }       
    }
}
