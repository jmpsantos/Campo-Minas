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

namespace G06.Minesweeper.UWP.ViewsUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AjudaUWP : Page
    {
        public AjudaUWP()
        {
            this.InitializeComponent();
        }

        private void BTSair_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void BTYT_Click(object sender, RoutedEventArgs e)
        {
            Uri URL = new Uri("https://www.youtube.com/watch?v=7B85WbEiYf4");
            WebViewAjuda.Navigate(URL);
        }

        private void BTWiki_Click(object sender, RoutedEventArgs e)
        {
            Uri URL = new Uri("https://pt.wikipedia.org/wiki/Campo_minado");
            WebViewAjuda.Navigate(URL);
        }
    }
}
