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

            listScore.DataContext = tmp;
            tmp.Sort();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (Application.Current.Resources.ContainsKey("joueur"))
            {
                Joueur joueur = (Joueur)Application.Current.Resources["joueur"];
                tmp.Add(joueur);
                tmp.Sort();
                Application.Current.Resources.Remove("joueur");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            Frame.Navigate(typeof(MainPage));
        }
    }
}
