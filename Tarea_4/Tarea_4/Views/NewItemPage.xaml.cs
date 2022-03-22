using System;
using System.Collections.Generic;
using System.ComponentModel;
using Tarea_4.Models;
using Tarea_4.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea_4.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}