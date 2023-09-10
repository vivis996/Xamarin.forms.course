using System.Collections.ObjectModel;
using xamarin.forms.course.MMVM.Views;

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

        private readonly IPageService _pageService;
        public PlayListsViewModel(IPageService pageService)
        {
            this._pageService = pageService;
        }

        public void AddPlaylist()
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
