﻿using System;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace GeoDrapeau
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class PageJeuM : Page
    {
        const int TEMPS_DEPART = 90;
        int score = 0;
        TabDrapeau tabDrapeaux = new TabDrapeau();
        TabDrapeau moyen = new TabDrapeau();
        Drapeau drapeauSoluce = new Drapeau("", 0, "");
        Random aleatoire = new Random();
        Temps temps = new Temps();
        List<string> correction = new List<string>();
        public PageJeuM()
        {
            this.InitializeComponent();

            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigated += OnRetour;

            tabDrapeaux.chargerDonnee();

            tabDrapeaux.chargerMoyen(moyen);

            lblScore.Text = score.ToString();

            btn.Click += btnClick;
            btn1.Click += btnClick;
            btn2.Click += btnClick;
            btn3.Click += btnClick;
            btn4.Click += btnClick;
            btn5.Click += btnClick;

            temps.TempsDepart = TEMPS_DEPART;
            temps.start();

            ucFinPartie.Visibility = Visibility.Collapsed;
            ucCorrection.Visibility = Visibility.Collapsed;
            menuApparait(false);

            Temps.timer.Tick += maj;

            btnLecture.IsEnabled = false;

            jouer();
        }
        public void maj(object sender, object e)
        {
            lblTImer.Text = temps.TempsDepart.ToString();
            if (temps.TempsDepart < 11 && temps.TempsDepart > 5)
            {
                lblTImer.Foreground = new SolidColorBrush(Windows.UI.Colors.Orange);
            }
            if (temps.TempsDepart < 5)
            {
                lblTImer.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
            }
        }
        public void setImage(string imagePath)
        {
            animImage.Begin();
            imgDrapeau.Source = new BitmapImage(new Uri("ms-appx:///" + imagePath));
        }
        void OnRetour(Object sender, NavigationEventArgs e)
        {
            if (((Frame)sender).CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility
                = AppViewBackButtonVisibility.Collapsed;
            }
        }
        private void OnPause_Click(object sender, RoutedEventArgs e)
        {
            temps.stop();

            btn.IsEnabled = false;
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;

            menuApparait(true);
            temps.EstFini = false;

            btnPause.IsEnabled = false;
            btnLecture.IsEnabled = true;
        }
        private void OnLecture_Click(object sender, RoutedEventArgs e)
        {
            lecture();
        }
        public void lecture()
        {
            temps.start();

            btn.IsEnabled = true;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;

            btnPause.IsEnabled = true;
            btnLecture.IsEnabled = false;

            menuApparait(false);
        }
        public void jouer()
        {

            if (temps.EstFini)
            {
                temps.stop();

                btn.IsEnabled = false;
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn3.IsEnabled = false;
                btn4.IsEnabled = false;
                btn5.IsEnabled = false;

                ucFinPartie.Visibility = Visibility.Visible;
                ucFinPartie.setScore(lblScore.Text);

                ucCorrection.afficheCorrection(correction);
                ucCorrection.Visibility = Visibility.Visible;

            }
            else
            {
                moyen.Clear();
                tabDrapeaux.chargerMoyen(moyen);

                drapeauSoluce = moyen[aleatoire.Next(moyen.Count)];
                moyen.Remove(drapeauSoluce);
                Drapeau drap1 = moyen[aleatoire.Next(moyen.Count)];
                moyen.Remove(drap1);
                Drapeau drap2 = moyen[aleatoire.Next(moyen.Count)];
                moyen.Remove(drap2);
                Drapeau drap3 = moyen[aleatoire.Next(moyen.Count)];
                moyen.Remove(drap3);
                Drapeau drap4 = moyen[aleatoire.Next(moyen.Count)];
                moyen.Remove(drap4);
                Drapeau drap5 = moyen[aleatoire.Next(moyen.Count)];
                moyen.Remove(drap5);

                List<Drapeau> tmp = new List<Drapeau>();
                tmp.Add(drapeauSoluce);
                tmp.Add(drap1);
                tmp.Add(drap2);
                tmp.Add(drap3);
                tmp.Add(drap4);
                tmp.Add(drap5);

                setImage(drapeauSoluce.ImagePath);

                int index = aleatoire.Next(tmp.Count);
                btn.Content = tmp[index].Nom;
                tmp.Remove(tmp[index]);

                index = aleatoire.Next(tmp.Count);
                btn1.Content = tmp[index].Nom;
                tmp.Remove(tmp[index]);

                index = aleatoire.Next(tmp.Count);
                btn2.Content = tmp[index].Nom;
                tmp.Remove(tmp[index]);

                index = aleatoire.Next(tmp.Count);
                btn3.Content = tmp[index].Nom;
                tmp.Remove(tmp[index]);

                index = aleatoire.Next(tmp.Count);
                btn4.Content = tmp[index].Nom;
                tmp.Remove(tmp[index]);

                index = aleatoire.Next(tmp.Count);
                btn5.Content = tmp[index].Nom;
                tmp.Remove(tmp[index]);
            }

        }
        public void btnClick(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            if (drapeauSoluce.Nom.Equals(bt.Content))
            {
                score += drapeauSoluce.Niveau;
                lblScore.Text = score.ToString();
                correction.Add(bt.Content.ToString() + ":" + drapeauSoluce.Nom + ":CORRECT");
            }
            else
            {
                correction.Add(bt.Content.ToString() + ":" + drapeauSoluce.Nom + ":FAUX");
            }
            jouer();
        }
        private void BtnRecommencer_Click(object sender, RoutedEventArgs e)
        {
            menuApparait(false);

            temps.EstFini = false;
            temps.TempsDepart = TEMPS_DEPART;

            lecture();

            jouer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
        public void menuApparait(Boolean choix)
        {
            if (choix)
            {
                rect.Visibility = Visibility.Visible;
                btnRecommencer.Visibility = Visibility.Visible;
                btnMenuPrincipal.Visibility = Visibility.Visible;
            }
            else
            {
                rect.Visibility = Visibility.Collapsed;
                btnRecommencer.Visibility = Visibility.Collapsed;
                btnMenuPrincipal.Visibility = Visibility.Collapsed;
            }
        }
    }
}
