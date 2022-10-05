using PracticeMobileFormsApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PracticeMobileFormsApp.Views
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