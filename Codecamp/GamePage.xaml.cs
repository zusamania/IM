using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Codecamp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {


        public GamePage()
        {
            this.InitializeComponent();

           /* Canvas Mycan = new Canvas();
	        Mycan.Width = 400;
	        Mycan.Height = 400;
            SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Colors.Blue);
            Mycan.Background = myBrush;
            Mycan.Margin = new Thickness(0, 0, 1000, 1000);
            MainPanel.Children.Add(Mycan);

            Canvas Mycan2 = new Canvas();
            Mycan2.Width = 400;
            Mycan2.Height = 400;
            SolidColorBrush myBrush2 = new SolidColorBrush(Windows.UI.Colors.Red);
            Mycan2.Background = myBrush2;
            Mycan2.Margin = new Thickness(100, 100, 1000, 1000);
            MainPanel.Children.Add(Mycan2); */

            //player pl = new player(1,10000);

            Image figure = new Image();
            figure.Width = 40;
            figure.Height = 40;
            figure.Source = new BitmapImage(new Uri("ms-appx:///Assets/bl1.png", UriKind.Absolute));
            figure.Margin = new Thickness(10, 10, 0, 0);
            figure.Name = "pl_black";
            figure.HorizontalAlignment = HorizontalAlignment.Left;
            figure.VerticalAlignment = VerticalAlignment.Top;
            MainPanel.Children.Add(figure);

            Image figure2 = new Image();
            figure2.Width = 40;
            figure2.Height = 40;
            figure2.Source = new BitmapImage(new Uri("ms-appx:///Assets/b1.png", UriKind.Absolute));
            figure2.Margin = new Thickness(10, 60, 0, 0);
            figure2.Name = "pl_black";
            figure2.HorizontalAlignment = HorizontalAlignment.Left;
            figure2.VerticalAlignment = VerticalAlignment.Top;
            MainPanel.Children.Add(figure2);

            Image figure3 = new Image();
            figure3.Width = 40;
            figure3.Height = 40;
            figure3.Source = new BitmapImage(new Uri("ms-appx:///Assets/g1.png", UriKind.Absolute));
            figure3.Margin = new Thickness(60, 10, 0, 0);
            figure3.Name = "pl_black";
            figure3.HorizontalAlignment = HorizontalAlignment.Left;
            figure3.VerticalAlignment = VerticalAlignment.Top;
            MainPanel.Children.Add(figure3);

            Image figure4 = new Image();
            figure4.Width = 40;
            figure4.Height = 40;
            figure4.Source = new BitmapImage(new Uri("ms-appx:///Assets/r1.png", UriKind.Absolute));
            figure4.Margin = new Thickness(60, 60, 0, 0);
            figure4.Name = "pl_black";
            figure4.HorizontalAlignment = HorizontalAlignment.Left;
            figure4.VerticalAlignment = VerticalAlignment.Top;
            MainPanel.Children.Add(figure4);


        }

        private void Roll(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int step = rnd.Next(1, 7);
            greetingOutput.Text = " " + step;
            //figure4.Margin = new Thickness(60, 60+30, 0, 0);

            /*Image figure4 = new Image();
            figure4.Width = 40;
            figure4.Height = 40;
            figure4.Source = new BitmapImage(new Uri("ms-appx:///Assets/r1.png", UriKind.Absolute));
            figure4.Margin = new Thickness(60, 60, 0, 0);
            figure4.Name = "pl_black";
            figure4.HorizontalAlignment = HorizontalAlignment.Left;
            figure4.VerticalAlignment = VerticalAlignment.Top;
            MainPanel.Children.Add(figure4);*/
        }

        public void buyField()
        {

        }
    }
}
