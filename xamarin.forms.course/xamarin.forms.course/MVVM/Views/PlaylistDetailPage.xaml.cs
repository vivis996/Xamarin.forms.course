using xamarin.forms.course.MMVM.Models;
using Xamarin.Forms;

namespace xamarin.forms.course.MMVM.Views
{
    public partial class PlaylistDetailPage : ContentPage
    {
        private Playlist _playlist;

        public PlaylistDetailPage(Playlist playlist)
        {
            this._playlist = playlist;

            InitializeComponent();

            this.title.Text = this._playlist.Title;
        }
    }
}
