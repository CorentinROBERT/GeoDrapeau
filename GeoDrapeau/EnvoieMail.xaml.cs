using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
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
    public sealed partial class EnvoieMail : Page
    {
        private string nom, prenom;
        private int score;
        private string message;
        Frame rootFrame = Window.Current.Content as Frame;

        public EnvoieMail()
        {
            
            this.InitializeComponent();
            
            rootFrame.Navigated += OnRetour;            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;

            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (Application.Current.Resources.ContainsKey("nom"))
            {
                nom = (string)Application.Current.Resources["nom"];                
                Application.Current.Resources.Remove("nom");
            }
            if (Application.Current.Resources.ContainsKey("prenom"))
            {
                prenom = (string)Application.Current.Resources["prenom"];                
                Application.Current.Resources.Remove("prenom");
            }
            if (Application.Current.Resources.ContainsKey("score"))
            {
                score = int.Parse((string)Application.Current.Resources["score"]);
                Application.Current.Resources.Remove("score");
            }
            message = "Bonjour, " + nom + " " + prenom + " à voulu vous informer qu'il avait participé à GeoDrapeau et que son score est de " + score + " points. \nSi vous pensez faire mieux, venez relever le défi.\n\nL'équipe de GeoDrapeau vous remercie.";
            lblText.Text = message;
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
                rootFrame.GoBack();
            }
        }

        private void BtnEnvoyer_Click(object sender, RoutedEventArgs e)
        {
            SendMail();
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void BtnSelectionContact_Click(object sender, RoutedEventArgs e)
        {
            ContactPicker contactPicker = new ContactPicker();
            Contact contact = await contactPicker.PickContactAsync();
            ContactStore contactStore = await ContactManager.RequestStoreAsync(ContactStoreAccessType.AllContactsReadOnly);
            if(contact != null)
            {
                Contact real = await contactStore.GetContactAsync(contact.Id);
                txtDestinataire.Text = real.Emails.FirstOrDefault<Windows.ApplicationModel.Contacts.ContactEmail>().Address;
            }
        }

        public async void SendMail()
        {
            EmailMessage emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient(txtDestinataire.Text));
            emailMessage.Subject = txtObjet.Text + ApplicationView.GetForCurrentView().Title.ToString().Trim();
            emailMessage.Body = message;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }
    }
}
