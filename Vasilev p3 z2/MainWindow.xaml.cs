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

namespace Vasilev_p3_z2
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

        private void btnClick(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(tbx1.Text, out double x1))
            {
                MessageBox.Show("Поле x только число");
            }
            if (!double.TryParse(tbx2.Text, out double x2))
            {
                MessageBox.Show("Поле y только число");
            }
            double A = Math.Abs(x2 - x1);
            MessageBox.Show($"Расстояние={A,1:f2}");
        }
    }
}