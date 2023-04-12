using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Md4Tp1Page : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public Md4Tp1Page()
        {
            InitializeComponent();
        }
    }
}
