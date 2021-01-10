using AlgoApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AlgoApp.Views
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