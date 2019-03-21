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
using System.Diagnostics;
using System.Xml;
using System.Text.RegularExpressions;

namespace RSSRedux
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoToArticle_OnClick(object sender, RoutedEventArgs e)
        {
            string path = (sender as Hyperlink).Tag as string;
            Console.WriteLine(path);
            Process.Start(path);
        }

        public static BitmapImage getImageSource(string input)
        {
            string imageSource = Regex.Match(input, "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
            BitmapImage logo = new BitmapImage();
            try
            {
                logo.BeginInit();
                logo.UriSource = new Uri(imageSource);
                logo.EndInit();
                Console.WriteLine(imageSource); //link to the image
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return logo;
        }

        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

        private void title_OnClick(object sender, MouseButtonEventArgs e)
        {
            string path = (sender as TextBlock).Tag as string;
            Console.WriteLine(path); // the whole description including tags
            desc.Text = path;
            desc.Text = StripHTML(desc.Text);
            imageLink.Source = getImageSource(path);
        }

        private void title_onClick(object sender, KeyEventArgs e)
        {
            
        }

        private void title_onClick(object sender, RoutedEventArgs e)
        {
            string path = (sender as TextBlock).Tag as string;
            Console.WriteLine(path); // the whole description including tags
            desc.Text = path;
            desc.Text = StripHTML(desc.Text);
            imageLink.Source = getImageSource(path);
        }
    }
}
