﻿using SampleListBinding.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleListBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonsView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public PersonsView()
        {
            InitializeComponent();

            BindingContext = new PersonsViewModel();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
