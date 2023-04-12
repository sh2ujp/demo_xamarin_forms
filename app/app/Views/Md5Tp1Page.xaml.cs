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
	public partial class Md5Tp1Page : ContentPage
	{
		public Md5Tp1Page ()
		{
			InitializeComponent ();
            Title = "tp: formulaire et images";
        }
	}
}