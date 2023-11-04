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

namespace DAMWpfImages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.imageFromUrl.Source = new BitmapImage(new Uri("https://images.pexels.com/photos/965345/pexels-photo-965345.jpeg?auto=compress&cs=tinysrgb&w=600"));
            
            this.imageRelative.Source = new BitmapImage(new Uri(Environment.CurrentDirectory+ "/Images/pexels-907487.jpg", UriKind.Absolute));

            this.imageLocalResource.Source = new BitmapImage(new Uri("/Images/pexels-574073.jpg", UriKind.Relative));

            this.imageLocalExternalResource.Source = new BitmapImage(new Uri("pack://application:,,/WpfImageLibrary;Component/Images/pexels-546819.jpg", UriKind.Absolute));
        }
    }
}
