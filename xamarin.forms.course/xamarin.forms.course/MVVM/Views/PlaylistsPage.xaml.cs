﻿using System;
using xamarin.forms.course.MVVM.ViewModels;
using Xamarin.Forms;

namespace xamarin.forms.course.MMVM.Views
{
    public partial class PlaylistsPage : ContentPage
    {
        public PlaylistsPage()
        {
            this.BindingContext = new PlayListsViewModel(new PageService());
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnPlaylistSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var playlist = e.SelectedItem as PlaylistViewModel;
            (this.BindingContext as PlayListsViewModel).SelectPlayList(playlist);
        }
    }
}
