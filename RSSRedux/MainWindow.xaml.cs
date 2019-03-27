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

        /// <summary>
        /// handles clicking a feed item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToArticle_OnClick(object sender, RoutedEventArgs e)
        {
            string path = (sender as Hyperlink).Tag as string;
            Console.WriteLine(path);
            Process.Start(path);
        }

        /// <summary>
        /// handles getting the image and converting it to usable format
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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

        /// <summary>
        /// function to handle stripping html tags from html
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

        /// <summary>
        /// when an rss element is selected, this puts the content into the elements below
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void title_OnClick(object sender, MouseButtonEventArgs e)
        {
            string path = (sender as TextBox).Tag as string;
            Console.WriteLine(path); // the whole description including tags
            desc.Text = path;
            desc.Text = StripHTML(desc.Text);
            imageLink.Source = getImageSource(path);
        }

        /// <summary>
        /// an as of yet undeployed button click handling function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSync_click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// an as of yet undeployed button click handling function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_click(object sender, RoutedEventArgs e)
        {
            formAddRSS newRSS = new formAddRSS();
            newRSS.Show();
        }

        /// <summary>
        /// an example of the keyboard focus change functions we tried but which didn't work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemSelected1(object sender, KeyboardFocusChangedEventArgs e)
        {
            ListBoxItem aa = e.OriginalSource as ListBoxItem;
            if (aa != null && !aa.IsSelected)
            {
                aa.IsSelected = true;
                string path = (sender as ListBoxItem).Tag as string;
                Console.WriteLine(path); // the whole description including tags
                desc.Text = "path";
                desc.Text = "StripHTML(desc.Text)";
                imageLink.Source = getImageSource(path);
                Console.WriteLine("ghfjghgdjh");
            }
        }

        private void TextBlock_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("fuck this shit");
            string path = (sender as ListBoxItem).Tag as string;
            Console.WriteLine(path); // the whole description including tags
            desc.Text = "path";
            desc.Text = "StripHTML(desc.Text)";
            imageLink.Source = getImageSource(path);
            Console.WriteLine("ghfjghgdjh");
        }

        /// <summary>
        /// as of yet not fully functional feed switching function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelected(object sender, RoutedEventArgs e)
        {
            ListBoxItem lbi = e.Source as ListBoxItem;

            ListBoxItem listBox = (ListBoxItem)sender;
            String lewis = listBox.ToString();

            if (lbi != null)
            {
                //Console.WriteLine(lbi.Content.ToString() + " is selected.");
                Console.WriteLine(lewis + " is selected!");
                //label1.Content = lewis;
                LB1.ItemsSource = "https://rss.cbc.ca/lineup/canada.xml"; // DOES NOT WORK
            }
        }
    }
}