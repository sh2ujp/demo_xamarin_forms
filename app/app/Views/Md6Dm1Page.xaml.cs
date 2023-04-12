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
	public partial class Md6Dm1Page : ContentPage
	{
        private bool formulaireHasErrors;

        public Md6Dm1Page ()
		{
			InitializeComponent ();
			this.Title = "demo: Contrôleur du formulaire";
		}

		private void Seconnecter_Clicked(object sender, EventArgs e)
		{
			this.effacerMessageErreur();
			this.formulaireHasErrors = false;


			// Controls des champs de saisie du formulaire
			if(
				this.email.Text == null ||
				string.IsNullOrWhiteSpace(this.email.Text.ToString())
			)
			{
				this.afficherMessageErreur("Veuillez saisir un email valide");
			}

			if(
				this.password.Text == null ||
				string.IsNullOrWhiteSpace(this.password.Text.ToString())
			)
			{
				this.afficherMessageErreur("Veuillez saisir un mot de passe valide");
			}

			if(
				this.codePostal.Text == null ||
				string.IsNullOrWhiteSpace(this.codePostal.Text.ToString()) ||
				this.codePostal.Text.ToString().Length > 5
			)
			{
				this.afficherMessageErreur("Veuillez saisir un code postal valide");
			}


			// Vérifie la présence d'erreurs avant d'aller plus loin dans le traitement
			if (this.formulaireHasErrors) return;


			if (this.seSouvenir.IsToggled)
				DisplayAlert(
					"Information", 
					"Vous serez automatiquement connecté au prochain lancement",
					"Compris!"
				);
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