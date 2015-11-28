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

namespace ScreenRGBTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Нажмите на экран, чтобы перейти к следующему слайду.");
        }

        Color currentColor = Colors.White;
        private void coloredGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (currentColor == Colors.White)
            {
                coloredGrid.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                currentColor = Colors.Red;
                MessageBox.Show("Проверка на битые пиксели.");
            }
            else if(currentColor == Colors.Red)
            {
                coloredGrid.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                currentColor = Colors.Green;
            }
            else if (currentColor == Colors.Green)
            {
                coloredGrid.Background = new SolidColorBrush(Color.FromRgb(0, 0, 255));
                currentColor = Colors.Blue;
            }
            else if(currentColor == Colors.Blue)
            {
                coloredGrid.Background = new SolidColorBrush(Colors.Orange);
                currentColor = Colors.Orange;
            }
            else if (currentColor == Colors.Orange)
            {
                coloredGrid.Background = new SolidColorBrush(Colors.LimeGreen);
                currentColor = Colors.LimeGreen;
            }
            else if(currentColor == Colors.LimeGreen)
            {
                coloredGrid.Background = new SolidColorBrush(Colors.Violet);
                currentColor = Colors.Violet;
            }
            else if (currentColor == Colors.Violet)
            {
                coloredGrid.Background = new SolidColorBrush(Colors.Black);
                currentColor = Colors.Black;
                MessageBox.Show("Проверка на засветы.");
            }
            else if(currentColor == Colors.Black)
            {
                this.Close();
            }
        }
    }
}
