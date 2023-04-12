using app.Services;
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
	public partial class Md7Dm1Page : ContentPage
	{
		public Md7Dm1Page ()
		{
			InitializeComponent ();
			Title = "demo: Service synthèse vocale";
        }

		private void SpeakBtn_Clicked(object sender, EventArgs e)
		{
			DependencyService.Get<ITextToSpeech>()
							 .Speak(this.message.Text.ToString());
		}

    }
}