using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Codecamp
{
    class player
    {
        public int money;
        //public Array cards();
        public int ptype;
        public int ppos;

        public void setPos(int dpos)
        {
            ppos = ppos + dpos;
        }
        public int getPos()
        {
            return ppos;
        }

        public player(int pt, int m)
        { 
            ptype = pt;
            money = m;
            ppos = 0;
        }
        public void move(int dmove)
        {
            //figure.margin.left = 100;
            //figure.Margin = new Thickness(10, 10, 1000, 1000);
        }

        public Image drawFigure()
        {
            Image figure = new Image();
            figure.Width = 50;
            figure.Height = 50;
            figure.Margin = new Thickness(10, 10, 1000, 1000);
            return figure;
            //figure.Source = (ImageSource)new ImageSourceConverter().ConvertFromString("/Assets/check.png");


           // ImageSource imgsrc = new ImageSource("Assets/g1.png");

            //figure.Source = "assets/g1.png";
            //SolidColorBrush myBrush2 = new SolidColorBrush(Windows.UI.Colors.Red);
            //Mycan2.Background = myBrush2;
            //Mycan2.Margin = new Thickness(100, 100, 1000, 1000);
            //MainPanel.Children.Add(Mycan2);
            //<Image HorizontalAlignment="Left" Height="42" Margin="64,631,0,0" VerticalAlignment="Top" Width="61" Source="assets/g1.png"/>
        }
    }
}
