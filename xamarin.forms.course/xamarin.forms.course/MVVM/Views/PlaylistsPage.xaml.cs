using xamarin.forms.course.MVVM.ViewModels;
using Xamarin.Forms;

namespace xamarin.forms.course.MMVM.Views
{
    public partial class PlaylistsPage : ContentPage
    {
        private PlayListsViewModel ViewModel
        {
            get => this.BindingContext as PlayListsViewModel;
            set => this.BindingContext = value;
        }

        public PlaylistsPage()
        {
            this.ViewModel = new PlayListsViewModel(new PageService());
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnPlaylistSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var playlist = e.SelectedItem as PlaylistViewModel;
            this.ViewModel.SelectPlaylistCommand.Execute(playlist);
        }
    }
}
