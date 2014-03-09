
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

        public int pl1pos, pl2pos, pl3pos, pl4pos, curmove, fldcnt, pl1score, pl2score, pl3score, pl4score, pr;
        public int[] stepsx, stepsy, price, income;
        int tmp1;
        //DispatcherTimer t = new DispatcherTimer();

        public GamePage()
        {
            this.InitializeComponent();
            //t.Interval = TimeSpan.FromMilliseconds(300);
            fldcnt = 34;
            pr = 33;
            //2348, 1390
            income = new int[34];
            stepsx = new int[fldcnt];
            stepsy = new int[fldcnt];
            price = new int[34];
            stepsx[0] = 2348;
            stepsy[0] = 1390;
            stepsx[1] = 2094;
            stepsy[1] = 1472;
            stepsx[2] = 1854;
            stepsy[2] = 1472;
            stepsx[3] = 1614;
            stepsy[3] = 1472;
            stepsx[4] = 1364;
            stepsy[4] = 1472;
            stepsx[5] = 1112;
            stepsy[5] = 1472;
            stepsx[6] = 874;
            stepsy[6] = 1472;
            stepsx[7] = 624;
            stepsy[7] = 1472;
            stepsx[8] = 368;
            stepsy[8] = 1472;
            stepsx[9] = 122;
            stepsy[9] = 1400;


            tmp1 = 13;

            stepsx[10] = 30;
            stepsy[10] = 1208;
            stepsx[11] = 30;
            stepsy[11] = 1056;
            stepsx[12] = 30;
            stepsy[12] = 800;
            stepsx[13] = 30;
            stepsy[13] = 10;
            stepsx[14] = 30;
            stepsy[14] = 100;
            stepsx[15] = 30;
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







            price[0] = -1;
            price[1] = 300;
            price[2] = -2;
            price[3] = 400;
            price[4] = 500;
            price[5] = -3;
            price[6] = 600;
            price[7] = 700;
            price[8] = 800;
            price[9] = -4;
            price[10] = 1000;
            price[11] = -2;
            price[12] = 1100;
            price[13] = 1200;
            price[14] = -3;
            price[15] = 1300;
            price[16] = 1400;
            price[17] = -5;
            price[18] = 1600;
            price[19] = -2;
            price[20] = 1700;
            price[21] = 1800;
            price[22] = 1900;
            price[23] = -3;
            price[24] = 2000;
            price[25] = 2100;
            price[26] = -6;
            price[27] = 2300;
            price[28] = -2;
            price[29] = 2400;
            price[30] = 2500;
            price[31] = -3;
            price[32] = 2600;
            price[33] = 2700;


            income[0] = 0;
            income[1] = 60;
            income[2] = 0;
            income[3] = 80;
            income[4] = 100;
            income[5] = 0;
            income[6] = 120;
            income[7] = 140;
            income[8] = 160;
            income[9] = 0;
            income[10] = 200;
            income[11] = 0;
            income[12] = 220;
            income[13] = 240;
            income[14] = 0;
            income[15] = 260;
            income[16] = 280;
            income[17] = 0;
            income[18] = 300;
            income[19] = 0;
            income[20] = 340;
            income[21] = 360;
            income[22] = 380;
            income[23] = 0;
            income[24] = 400;
            income[25] = 420;
            income[26] = 0;
            income[27] = 460;
            income[28] = 0;
            income[29] = 480;
            income[30] = 500;
            income[31] = 0;
            income[32] = 520;
            income[33] = 540;

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
            //pl1fig.Margin = new Thickness(stepsx[0]-50, stepsy[0]-50, 0, 0);
            pl1fig.Margin = new Thickness(stepsx[tmp1], stepsy[tmp1], 0, 0);
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
            pl2fig.Margin = new Thickness(stepsx[0]+50, stepsy[0]+50, 0, 0);
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
                pl3fig.Margin = new Thickness(stepsx[0]+50, stepsy[0]-50, 0, 0);
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
                pl4fig.Margin = new Thickness(stepsx[0]-50, stepsy[0]+50, 0, 0);
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
                cubic.Margin = new Thickness(2200, 1200, 0, 0);
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
                movePlayer(step, pl1pos, pl1fig);
            } 
            else if (curmove == 2)
            {
                movePlayer(step, pl2pos, pl2fig);
            }
            else if (curmove == 3)
            {
                movePlayer(step, pl3pos, pl3fig);
            } 
            else
            {
                movePlayer(step, pl4pos, pl4fig);
            }
            curmove++;
            if (curmove > Codecamp.GameRules.p) curmove = 1;
        }

        public void movePlayer(int step, int plpos, Image plfig)
        {        
            plpos = plpos + step;
            if (plpos > fldcnt - 2) plpos = plpos - fldcnt + 1;
            plfig.Margin = new Thickness(stepsx[plpos], stepsy[plpos], 0, 0);

            if (plpos >= 0 & plpos<4)
            {
                MainPanel.Margin = new Thickness(-1130, -766, 0, 0);
                rollBtn.Margin = new Thickness(1822, 1227, 0, 0);
                cubic.Margin = new Thickness(1822, 1100, 0, 0);
            }
            else if (plpos >= 4 & plpos<8)
            {
                MainPanel.Margin = new Thickness(-500, -766, 0, 0);
                rollBtn.Margin = new Thickness(1400, 1227, 0, 0);
                cubic.Margin = new Thickness(1400, 1100, 0, 0);
            }
            else if (plpos >= 8 & plpos < 12)
            {
                MainPanel.Margin = new Thickness(0, -766, 0, 0);
                rollBtn.Margin = new Thickness(500, 1227, 0, 0);
                cubic.Margin = new Thickness(500, 1100, 0, 0);
            }
            else if (plpos >= 0 & plpos < 4)
            {

            }

        }
        

        public void buyField()
        {

        }
    }
}
