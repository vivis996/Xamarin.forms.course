using System;
using System.Collections.ObjectModel;
using xamarin.forms.course.MMVM.Models;
using Xamarin.Forms;

namespace xamarin.forms.course.MMVM.Views
{
    public partial class PlaylistsPage : ContentPage
    {
        private readonly ObservableCollection<Playlist> _playlists =
                     new ObservableCollection<Playlist>();

        public PlaylistsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            playlistsListView.ItemsSource = this._playlists;

            base.OnAppearing();
        }

        void OnAddPlaylist(object sender, EventArgs e)
        {
            var newPlaylist = "Playlist " + (this._playlists.Count + 1);

            this._playlists.Add(new Playlist { Title = newPlaylist });

            this.Title = $"{this._playlists.Count} Playlists";
        }

        void OnPlaylistSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is null)
                return;

            var playlist = e.SelectedItem as Playlist;
            playlist.IsFavorite = !playlist.IsFavorite;

            playlistsListView.SelectedItem = null;

            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
