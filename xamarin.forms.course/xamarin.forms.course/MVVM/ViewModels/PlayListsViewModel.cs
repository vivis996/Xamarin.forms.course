using System.Collections.ObjectModel;
using System.Windows.Input;
using xamarin.forms.course.MMVM.Views;
using Xamarin.Forms;

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

        public ICommand AddPlaylistCommand { get; set; }

        private readonly IPageService _pageService;
        public PlayListsViewModel(IPageService pageService)
        {
            this._pageService = pageService;

            this.AddPlaylistCommand = new Command(AddPlaylist);
        }

        private void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (this.Playlists.Count + 1);

            this.Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }

        public async void SelectPlayList(PlaylistViewModel playlist)
        {
            if (playlist is null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;

            this.SelectedPlaylist = null;
            await this._pageService.PushAsync(new PlaylistDetailPage(playlist));
        }
    }
}
