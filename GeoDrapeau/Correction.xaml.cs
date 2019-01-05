using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page https://go.microsoft.com/fwlink/?LinkId=234236

namespace GeoDrapeau
{
    public sealed partial class Correction : UserControl
    {
        TabDrapeau tabDrapeaux = new TabDrapeau();
        public Correction()
        {
            this.InitializeComponent();
            tabDrapeaux.chargerDonnee();
        }

        public void afficheCorrection(List<string> liste)
        {
            foreach(string tmp in liste)
            {
                listCorrection.Items.Add(tmp);
            }
        }

        private void ListCorrection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ligne = listCorrection.SelectedItem.ToString();
            string[] ligne2 = ligne.Split(':');
            Drapeau tmp = tabDrapeaux.chercheDrapeauNom(ligne2[1]);
            imgCorrige.Source = new BitmapImage(new Uri("ms-appx:///" + tmp.ImagePath));
        }
    }
}
