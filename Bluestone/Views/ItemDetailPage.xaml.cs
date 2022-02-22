using Bluestone.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Bluestone.Views
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