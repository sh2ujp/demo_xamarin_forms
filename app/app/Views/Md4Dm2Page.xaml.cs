﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Md4Dm2Page : ContentPage
	{
		public Md4Dm2Page ()
		{
			InitializeComponent ();
			Title = "demo: Grid Layout";
		}
	}
}