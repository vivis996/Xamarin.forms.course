using System.Collections.ObjectModel;
using xamarin.forms.course.MMVM.Models;

namespace xamarin.forms.course.MVVM.ViewModels
{
    public class PlayListsViewModel
    {
        public ObservableCollection<Playlist> Playlists { get; private set; } =
                     new ObservableCollection<Playlist>();

        public Playlist SelectedPlaylist { get; set; }

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
