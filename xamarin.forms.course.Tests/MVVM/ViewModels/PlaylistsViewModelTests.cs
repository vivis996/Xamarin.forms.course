using Moq;
using xamarin.forms.course.MMVM.Views;
using xamarin.forms.course.MVVM.ViewModels;
using Assert = NUnit.Framework.Assert;

namespace xamarin.forms.course.Tests.MVVM.ViewModels;

[TestFixture]
public class PlaylistsViewModelTests
{
    private PlayListsViewModel _viewModel;
    private Mock<IPageService> _pageService;

    [SetUp]
    public void Setup()
    {
        this._pageService = new();
        this._viewModel = new PlayListsViewModel(this._pageService.Object);
    }

    [Test]
    public void AddPlayList_WhenCalled_TheNewPlaylistShouldBeInTheList()
    {
        this._viewModel.AddPlaylistCommand.Execute(null);

        Assert.AreEqual(1, this._viewModel.Playlists.Count);
    }

    [Test]
    public void SelectPlaylist_WhenCalled_TheSelectedItemShouldBeDeselected()
    {
        var playlist = new PlaylistViewModel();
        this._viewModel.Playlists.Add(playlist);
        this._viewModel.SelectPlaylistCommand.Execute(playlist);

        Assert.IsNull(this._viewModel.SelectedPlaylist);
    }

    [Test]
    public void SelectPlaylist_WhenCalled_IsFavoritePropertyOfPlaylistIsToggled()
    {
        var playlist = new PlaylistViewModel();
        this._viewModel.Playlists.Add(playlist);
        this._viewModel.SelectPlaylistCommand.Execute(playlist);

        Assert.IsTrue(playlist.IsFavorite);
    }

    [Test]
    public void SelectPlaylist_WhenCalled_ShouldNavigateTheUserToPlaylistDetailPage()
    {
        var playlist = new PlaylistViewModel();
        this._viewModel.Playlists.Add(playlist);
        this._viewModel.SelectPlaylistCommand.Execute(playlist);

        this._pageService.Verify(p => p.PushAsync(It.IsAny<PlaylistDetailPage>()));
    }
}
