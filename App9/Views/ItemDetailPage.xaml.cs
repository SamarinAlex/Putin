using App9.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App9.Views
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