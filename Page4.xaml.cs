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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CurrencyApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page4 : Page
    {
        public Page4()
        {
            this.InitializeComponent();
        }

        private void p1exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void USD_to_GBP_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page1));
        }

        private void GBP_to_USD_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page2));
        }

        private void GBP_to_Euro_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page3));
        }

        private void Euro_to_GBP_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page4));
        }
    }
}
