using System.ComponentModel;
using Tarea_4.ViewModels;
using Xamarin.Forms;

namespace Tarea_4.Views
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