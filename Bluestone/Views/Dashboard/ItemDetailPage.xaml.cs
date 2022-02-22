using Bluestone.ViewModels.Dashboard;
using System.ComponentModel;
using Xamarin.Forms;

namespace Bluestone.Views.Dashboard
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