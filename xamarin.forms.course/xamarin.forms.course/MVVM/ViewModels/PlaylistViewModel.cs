using System.Drawing;

namespace xamarin.forms.course.MVVM.ViewModels
{
	public class PlaylistViewModel : BaseViewModel
    {
        public string Title { get; set; }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get { return this._isFavorite; }
            set
            {
                SetValue(ref this._isFavorite, value);

                OnPropertyChanged(nameof(Color));
            }
        }

        public Color Color
        {
            get { return this.IsFavorite ? Color.Pink : Color.Black; }
        }
    }
}
