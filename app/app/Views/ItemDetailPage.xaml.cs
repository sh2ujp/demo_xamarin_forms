using app.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace app.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}