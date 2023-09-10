using System.Collections.ObjectModel;
using xamarin.forms.course.MMVM.Models;

namespace xamarin.forms.course.MVVM.ViewModels
{
    public class PlayListsViewModel : BaseViewModel
    {
        public ObservableCollection<PlaylistViewModel> Playlists { get; private set; } =
                     new ObservableCollection<PlaylistViewModel>();

        private PlaylistViewModel _selectedPlaylist;
        public PlaylistViewModel SelectedPlaylist
        {
            get => this._selectedPlaylist;
            set => SetValue(ref this._selectedPlaylist, value);
        }

        public void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (this.Playlists.Count + 1);

            this.Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }

        public void SelectPlayList(PlaylistViewModel playlist)
        {
            if (playlist is null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            this.SelectedPlaylist = null;
            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
