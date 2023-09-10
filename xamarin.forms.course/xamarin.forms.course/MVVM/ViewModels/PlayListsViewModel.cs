using System.Collections.ObjectModel;
using xamarin.forms.course.MMVM.Models;

namespace xamarin.forms.course.MVVM.ViewModels
{
    public class PlayListsViewModel : BaseViewModel
    {
        public ObservableCollection<Playlist> Playlists { get; private set; } =
                     new ObservableCollection<Playlist>();

        private Playlist _selectedPlaylist;
        public Playlist SelectedPlaylist
        {
            get => this._selectedPlaylist;
            set => SetValue(ref this._selectedPlaylist, value);
        }

        public void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (this.Playlists.Count + 1);

            this.Playlists.Add(new Playlist { Title = newPlaylist });
        }

        public void SelectPlayList(Playlist playlist)
        {
            if (playlist is null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            this.SelectedPlaylist = null;
            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
