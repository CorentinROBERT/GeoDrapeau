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

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page https://go.microsoft.com/fwlink/?LinkId=234236

namespace GeoDrapeau
{
    public sealed partial class FinPartie : UserControl
    {
        Frame rootFrame = Window.Current.Content as Frame;
        public FinPartie()
        {
            this.InitializeComponent();            
        }

        private void BtnAjouterScore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnIgnorer_Click(object sender, RoutedEventArgs e)
        {
            rootFrame.Navigate(typeof(MainPage));
        }

        private void BtnShareMail_Click(object sender, RoutedEventArgs e)
        {

        }
        public void setScore(string score)
        {
            lblScore.Text = score;
        }

        private void TxtPrenom_GotFocus(object sender, RoutedEventArgs e)
        {
            txtPrenom.Text="";
        }

        private void TxtNom_GotFocus(object sender, RoutedEventArgs e)
        {
            txtNom.Text = "";
        }
    }
}
