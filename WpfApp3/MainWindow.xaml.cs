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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           

            try {

            pic01.Background = new ImageBrush(
                new BitmapImage(
                    new Uri(@"C:\Users\User1\source\repos\WpfApp3\WpfApp3\Image\01.png")));
            pic02.Background = new ImageBrush(
                new BitmapImage(
                    new Uri(@"C:\Users\User1\source\repos\WpfApp3\WpfApp3\Image\02.png")));
            pic03.Background = new ImageBrush(
                new BitmapImage(
                    new Uri(@"C:\Users\User1\source\repos\WpfApp3\WpfApp3\Image\03.png")));
            pic04.Background = new ImageBrush(
                new BitmapImage(
                    new Uri(@"C:\Users\User1\source\repos\WpfApp3\WpfApp3\Image\04.png")));
            pic05.Background = new ImageBrush(
                new BitmapImage(
                    new Uri(@"C:\Users\User1\source\repos\WpfApp3\WpfApp3\Image\05.png")));
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
