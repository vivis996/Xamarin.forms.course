using System;
using xamarin.forms.course.MMVM.Models;
using xamarin.forms.course.MVVM.ViewModels;
using Xamarin.Forms;

namespace xamarin.forms.course.MMVM.Views
{
    public partial class PlaylistsPage : ContentPage
    {
        public PlaylistsPage()
        {
            this.BindingContext = new PlayListsViewModel();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnAddPlaylist(object sender, EventArgs e)
        {
            (this.BindingContext as PlayListsViewModel).AddPlaylist();
        }

        void OnPlaylistSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var playlist = e.SelectedItem as Playlist;
            (this.BindingContext as PlayListsViewModel).SelectPlayList(playlist);
        }
    }
}
