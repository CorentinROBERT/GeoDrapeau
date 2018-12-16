using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
            
            
            Application.Current.Resources["nom"] = txtNom.Text;
            Application.Current.Resources["prenom"] = txtPrenom.Text;
            Application.Current.Resources["score"] = lblScore.Text;

            rootFrame.Navigate(typeof(EnvoieMail));
            

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
        private async Task ComposeEmail(Windows.ApplicationModel.Contacts.Contact recipient,string subject, string messageBody)
        {
            var emailMessage = new Windows.ApplicationModel.Email.EmailMessage();
            emailMessage.Body = messageBody;

            var email = recipient.Emails.FirstOrDefault<Windows.ApplicationModel.Contacts.ContactEmail>();
            if (email != null)
            {
                var emailRecipient = new Windows.ApplicationModel.Email.EmailRecipient(email.Address);
                emailMessage.To.Add(emailRecipient);
                emailMessage.Subject = subject;
            }

            await Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }
    }
}
