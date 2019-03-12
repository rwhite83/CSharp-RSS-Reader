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
        private void testClick(object sender, RoutedEventArgs e)
        {
            string path = (sender as TextBlock).Tag as string;
            Console.WriteLine(path);
            desc.Text = path;
            desc.Text = StripHTML(desc.Text);
        }

        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }
    }
}
