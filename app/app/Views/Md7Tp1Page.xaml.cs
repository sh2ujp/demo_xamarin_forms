﻿using app.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Md7Tp1Page : ContentPage
	{
        private bool formulaireHasErrors;

        public Md7Tp1Page()
		{
			InitializeComponent ();
			this.Title = "tp: connexion de l'utilisateur";

            // simule la connection / déconnection
            this.disconnectUser();
        }

        private void ConnectionBtn_Clicked(object sender, EventArgs e)
        {
            this.effacerMessageErreur();
            this.formulaireHasErrors = false;


            // Controls des champs de saisie du formulaire
            if (
                this.formLogin.Text == null ||
                string.IsNullOrWhiteSpace(this.formLogin.Text.ToString())
            )
            {
                this.afficherMessageErreur("Veuillez saisir un identifiant valide");
            }

            if (
                this.formPassword.Text == null ||
                string.IsNullOrWhiteSpace(this.formPassword.Text.ToString())
            )
            {
                this.afficherMessageErreur("Veuillez saisir un mot de passe valide");
            }


            // Vérifie la présence d'erreurs avant d'aller plus loin dans le traitement
            if (this.formulaireHasErrors) return;

            var username = this.formLogin.Text.ToString();
            var password = this.formPassword.Text.ToString();

            // Vérifie les identifiants grâce au service
            if (!DependencyService.Get<ITweeterService>().Authenticate(username, password))
            {
                this.afficherMessageErreur("La connexion a échoué");
                return;
            }
            
            // simule la connexion
            this.connectUser(this.formLogin.Text);

            if (this.formRememberMe.IsToggled)
                DisplayAlert(
                    "Information",
                    "Vous serez automatiquement connecté au prochain lancement",
                    "Compris!"    
            );
        }

        private void disconnectUser()
        {
            // affiche le formulaire
            this.connectionForm.IsVisible = true;

            // masque la page des Tweets
            this.topMenu.IsVisible = false;
            this.tweetList.IsVisible = false;
            this.footerMenu.IsVisible = false;
        }

        private void connectUser(string text)
        {
            // masque le formulaire
            this.connectionForm.IsVisible = false;

            // affiche la page des Tweets
            this.topMenu.IsVisible = true;
            this.tweetList.IsVisible = true;
            this.footerMenu.IsVisible = true;
        }

        private void effacerMessageErreur()
        {
            this.errorMessage.Text = "";
            this.errorMessage.IsVisible = false;
        }

        private void afficherMessageErreur(string message)
        {
            this.formulaireHasErrors = true;
            this.errorMessage.Text += message + "\n";
            this.errorMessage.IsVisible = true;
        }
    }
}