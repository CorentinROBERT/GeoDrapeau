using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace GeoDrapeau
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Score : Page
    {
        static List<Joueur> tmp = new List<Joueur>();
        public Score()
        {
            this.InitializeComponent();
            
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigated += OnRetour;            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
            
            listScore.DataContext = tmp;
            /*
            tmp.Add(new Joueur("Robert", "Corentin", 20, "corentin.robert@gmail.com"));
            tmp.Add(new Joueur("LAMAUVE", "Adèle", 40, "corentin.robert@gmail.com"));
            tmp.Add(new Joueur("Robert", "Pascal", 35, "corentin.robert@gmail.com"));
            */
            tmp.Sort();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (Application.Current.Resources.ContainsKey("listScore"))
            {
                tmp = (List<Joueur>)Application.Current.Resources["listScore"];
                tmp.Sort();
            }
            Application.Current.Resources.Remove("listScore");
            Application.Current.Resources["listScore"] = tmp;
        }
        void OnRetour(Object sender, NavigationEventArgs e)
        {
            if (((Frame)sender).CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility
                = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility
                = AppViewBackButtonVisibility.Collapsed;
            }
        }
        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                e.Handled = true;
                Frame.Navigate(typeof(MainPage));
            }
        }
    }
}
