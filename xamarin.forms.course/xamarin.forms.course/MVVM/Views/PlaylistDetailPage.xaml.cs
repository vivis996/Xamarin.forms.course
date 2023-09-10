using xamarin.forms.course.MVVM.ViewModels;
using Xamarin.Forms;

namespace xamarin.forms.course.MMVM.Views
{
    public partial class PlaylistDetailPage : ContentPage
    {
        private PlaylistViewModel _playlist;

        public PlaylistDetailPage(PlaylistViewModel playlist)
        {
            this._playlist = playlist;

            InitializeComponent();

            this.title.Text = this._playlist.Title;
        }
    }
}
