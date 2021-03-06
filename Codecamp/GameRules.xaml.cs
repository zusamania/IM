﻿using Codecamp.Common;
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

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Codecamp
{ 
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>

    public partial class GameRules : Page
    {
        DispatcherTimer t = new DispatcherTimer();
        int a = 0;


        public static int p, pc, ca;
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public GameRules()
        {
            this.InitializeComponent();

            pc = 1;
            Black.Source = new BitmapImage(new Uri("ms-appx:///Assets/Black_ok.png", UriKind.Absolute));
            Red.Source = new BitmapImage(new Uri("ms-appx:///Assets/Red.png", UriKind.Absolute));
            Blue.Source = new BitmapImage(new Uri("ms-appx:///Assets/Blue.png", UriKind.Absolute));
            Green.Source = new BitmapImage(new Uri("ms-appx:///Assets/Green.png", UriKind.Absolute));

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            t.Interval = TimeSpan.FromMilliseconds(200);
            t.Tick += t_Tick;
            t.Start();
        }

        void t_Tick(object sender, object e)
        {
            switch (a % 6)
            {
                case 0: cube_anim.Source = new BitmapImage(new Uri("ms-appx:///Assets/1Cubic.png", UriKind.Absolute)); break;
                case 1: cube_anim.Source = new BitmapImage(new Uri("ms-appx:///Assets/2Cubic.png", UriKind.Absolute)); break;
                case 2: cube_anim.Source = new BitmapImage(new Uri("ms-appx:///Assets/3Cubic.png", UriKind.Absolute)); break;
                case 3: cube_anim.Source = new BitmapImage(new Uri("ms-appx:///Assets/4Cubic.png", UriKind.Absolute)); break;
                case 4: cube_anim.Source = new BitmapImage(new Uri("ms-appx:///Assets/5Cubic.png", UriKind.Absolute)); break;
                case 5: cube_anim.Source = new BitmapImage(new Uri("ms-appx:///Assets/6Cubic.png", UriKind.Absolute)); break;
            }
            ++a;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Player_error.Visibility = Windows.UI.Xaml.Visibility.Collapsed; 
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {

            p = Convert.ToInt32(Pnum.Text);
            ca = Convert.ToInt32(Cash_amo.Text);

            if ((p > 4) | (p < 2))
            {

                Player_error.Visibility = Windows.UI.Xaml.Visibility.Visible; 

            }

            if (Player_error.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
            {
                this.Frame.Navigate(typeof(GamePage));
            }
            t.Stop();
            
        }

        private void Black_Tapped(object sender, TappedRoutedEventArgs e)
        {
            pc = 1;
            Black.Source = new BitmapImage(new Uri("ms-appx:///Assets/Black_ok.png", UriKind.Absolute));
            Red.Source = new BitmapImage(new Uri("ms-appx:///Assets/Red.png", UriKind.Absolute));
            Blue.Source = new BitmapImage(new Uri("ms-appx:///Assets/Blue.png", UriKind.Absolute));
            Green.Source = new BitmapImage(new Uri("ms-appx:///Assets/Green.png", UriKind.Absolute));
        }

        private void Red_Tapped(object sender, TappedRoutedEventArgs e)
        {
            pc = 2;
            Black.Source = new BitmapImage(new Uri("ms-appx:///Assets/Black.png", UriKind.Absolute));
            Red.Source = new BitmapImage(new Uri("ms-appx:///Assets/Red_ok.png", UriKind.Absolute));
            Blue.Source = new BitmapImage(new Uri("ms-appx:///Assets/Blue.png", UriKind.Absolute));
            Green.Source = new BitmapImage(new Uri("ms-appx:///Assets/Green.png", UriKind.Absolute));
        }

        private void Green_Tapped(object sender, TappedRoutedEventArgs e)
        {
            pc = 3;
            Black.Source = new BitmapImage(new Uri("ms-appx:///Assets/Black.png", UriKind.Absolute));
            Red.Source = new BitmapImage(new Uri("ms-appx:///Assets/Red.png", UriKind.Absolute));
            Blue.Source = new BitmapImage(new Uri("ms-appx:///Assets/Blue.png", UriKind.Absolute));
            Green.Source = new BitmapImage(new Uri("ms-appx:///Assets/Green_ok.png", UriKind.Absolute));
        }

        private void Blue_Tapped(object sender, TappedRoutedEventArgs e)
        {
            pc = 4;
            Black.Source = new BitmapImage(new Uri("ms-appx:///Assets/Black.png", UriKind.Absolute));
            Red.Source = new BitmapImage(new Uri("ms-appx:///Assets/Red.png", UriKind.Absolute));
            Blue.Source = new BitmapImage(new Uri("ms-appx:///Assets/Blue_ok.png", UriKind.Absolute));
            Green.Source = new BitmapImage(new Uri("ms-appx:///Assets/Green.png", UriKind.Absolute));
        }

               
    }
}