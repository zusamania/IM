
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
        public Image pl1fig, pl2fig, pl3fig, pl4fig, cubic;
        public int pl1pos, pl2pos, pl3pos, pl4pos, curmove, fldcnt, pl1score, pl2score, pl3score, pl4score;
        public int[] stepsx,stepsy;

        DispatcherTimer t = new DispatcherTimer();

        public GamePage()
        {
            this.InitializeComponent();
            fldcnt = 35;
            stepsx = new int[fldcnt];
            stepsy = new int[fldcnt];
            stepsx[0] = 10;
            stepsy[0] = 10;
            stepsx[1] = 100;
            stepsy[1] = 10;
            stepsx[2] = 200;
            stepsy[2] = 10;
            stepsx[3] = 300;
            stepsy[3] = 10;
            stepsx[4] = 400;
            stepsy[4] = 10;
            stepsx[5] = 500;
            stepsy[5] = 10;
            stepsx[6] = 600;
            stepsy[6] = 10;
            stepsx[7] = 700;
            stepsy[7] = 10;
            stepsx[8] = 800;
            stepsy[8] = 10;
            stepsx[9] = 900;
            stepsy[9] = 10;
            stepsx[10] = 1000;
            stepsy[10] = 10;
            stepsx[11] = 1100;
            stepsy[11] = 10;
            stepsx[12] = 1200;
            stepsy[12] = 10;
            stepsx[13] = 1300;
            stepsy[13] = 10;
            stepsx[14] = 1300;
            stepsy[14] = 100;
            stepsx[15] = 1300;
            stepsy[15] = 200;
            stepsx[16] = 1300;
            stepsy[16] = 300;
            stepsx[17] = 1300;
            stepsy[17] = 400;
            stepsx[18] = 1300;
            stepsy[18] = 500;
            stepsx[19] = 1300;
            stepsy[19] = 600;
            stepsx[20] = 1300;
            stepsy[20] = 700;
            stepsx[21] = 1300;
            stepsy[21] = 700;
            stepsx[22] = 1200;
            stepsy[22] = 700;
            stepsx[23] = 1100;
            stepsy[23] = 700;
            stepsx[24] = 1000;
            stepsy[24] = 700;
            stepsx[25] = 900;
            stepsy[25] = 700;
            stepsx[26] = 800;
            stepsy[26] = 700;
            stepsx[27] = 700;
            stepsy[27] = 700;
            stepsx[28] = 600;
            stepsy[28] = 700;
            stepsx[29] = 500;
            stepsy[29] = 700;
            stepsx[30] = 400;
            stepsy[30] = 700;
            stepsx[31] = 300;
            stepsy[31] = 700;
            stepsx[32] = 200;
            stepsy[32] = 700;
            stepsx[33] = 100;
            stepsy[33] = 700;
            stepsx[34] = 10;
            stepsy[34] = 700;

            pl1pos = pl2pos = pl3pos = pl4pos = 0;
            pl1score = pl2score = pl3score = pl4score = Codecamp.GameRules.ca;
            curmove = 1;
            greetingOutput.Text = " " + pl1score;

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
            //public int p, pc, ca;

            pl1fig = new Image();
            pl1fig.Width = 40;
            pl1fig.Height = 40;
            if (Codecamp.GameRules.pc == 1)
            {
                pl1fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/b1.png", UriKind.Absolute));
            }
            else if (Codecamp.GameRules.pc == 2)
            {
                pl1fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/r1.png", UriKind.Absolute));
            }
            else if (Codecamp.GameRules.pc == 3)
            {
                pl1fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/g1.png", UriKind.Absolute));
            }
            else
            {
                pl1fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/bl1.png", UriKind.Absolute));
            }
            pl1fig.Margin = new Thickness(10, 10, 0, 0);
            pl1fig.Name = "pl_black";
            pl1fig.HorizontalAlignment = HorizontalAlignment.Left;
            pl1fig.VerticalAlignment = VerticalAlignment.Top;
            MainPanel.Children.Add(pl1fig);

            pl2fig = new Image();
            pl2fig.Width = 40;
            pl2fig.Height = 40;
            if (Codecamp.GameRules.pc==1)
            {
                pl2fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/bl1.png", UriKind.Absolute));
            }
            else
            {
                pl2fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/b1.png", UriKind.Absolute));
            }
            pl2fig.Margin = new Thickness(10, 60, 0, 0);
            pl2fig.Name = "pl_black";
            pl2fig.HorizontalAlignment = HorizontalAlignment.Left;
            pl2fig.VerticalAlignment = VerticalAlignment.Top;
            MainPanel.Children.Add(pl2fig);


           
            if (Codecamp.GameRules.p > 2)
            {
                pl3fig = new Image();
                pl3fig.Width = 40;
                pl3fig.Height = 40;
                if (Codecamp.GameRules.pc == 3)
                {
                    pl3fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/b1.png", UriKind.Absolute));
                }
                else
                {
                    pl3fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/g1.png", UriKind.Absolute));
                }
                pl3fig.Margin = new Thickness(60, 10, 0, 0);
                pl3fig.Name = "pl_black";
                pl3fig.HorizontalAlignment = HorizontalAlignment.Left;
                pl3fig.VerticalAlignment = VerticalAlignment.Top;
                MainPanel.Children.Add(pl3fig);
            }

            if (Codecamp.GameRules.p > 3)
            {
                pl4fig = new Image();
                pl4fig.Width = 40;
                pl4fig.Height = 40;
                if (Codecamp.GameRules.pc == 2)
                {
                    pl4fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/b1.png", UriKind.Absolute));
                }
                else
                {
                    pl4fig.Source = new BitmapImage(new Uri("ms-appx:///Assets/r1.png", UriKind.Absolute));
                }
                pl4fig.Margin = new Thickness(60, 60, 0, 0);
                pl4fig.Name = "pl_black";
                pl4fig.HorizontalAlignment = HorizontalAlignment.Left;
                pl4fig.VerticalAlignment = VerticalAlignment.Top;
                MainPanel.Children.Add(pl4fig);
            }
            
        }

        private void Roll(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int step = rnd.Next(1, 7);
            
            
            if (cubic == null)
            {
                cubic = new Image();
                cubic.Width = 60;
                cubic.Height = 60;
                cubic.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + step + "Cubic.png", UriKind.Absolute));
                cubic.Margin = new Thickness(300, 300, 0, 0);
                cubic.Name = "cubic";
                cubic.HorizontalAlignment = HorizontalAlignment.Left;
                cubic.VerticalAlignment = VerticalAlignment.Top;
                MainPanel.Children.Add(cubic);
            }
            else
            {
                cubic.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + step + "Cubic.png", UriKind.Absolute));
            }

            if (curmove == 1)
            {
                pl1pos = pl1pos + step;
                if (pl1pos > fldcnt-2) pl1pos = pl1pos - fldcnt + 1;
                pl1fig.Margin = new Thickness(stepsx[pl1pos], stepsy[pl1pos], 0, 0);
            } 
            else if (curmove == 2)
            {
                pl2pos = pl2pos + step;
                if (pl2pos > fldcnt - 2) pl2pos = pl2pos - fldcnt + 1;
                pl2fig.Margin = new Thickness(stepsx[pl2pos], stepsy[pl2pos], 0, 0);
            }
            else if (curmove == 3)
            {
                pl3pos = pl3pos + step;
                if (pl3pos > fldcnt - 2) pl3pos = pl3pos - fldcnt + 1;
                pl3fig.Margin = new Thickness(stepsx[pl3pos], stepsy[pl3pos], 0, 0);
            } 
            else
            {
                pl4pos = pl4pos + step;
                if (pl4pos > fldcnt - 2) pl4pos = pl4pos - fldcnt + 1;
                pl4fig.Margin = new Thickness(stepsx[pl4pos], stepsy[pl4pos], 0, 0);
            }
            curmove++;
            if (curmove > Codecamp.GameRules.p) curmove = 1;
        }

        public void buyField()
        {

        }
    }
}
