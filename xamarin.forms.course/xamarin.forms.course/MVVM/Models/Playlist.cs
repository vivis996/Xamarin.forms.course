using xamarin.forms.course.MVVM.ViewModels;
using Xamarin.Forms;

namespace xamarin.forms.course.MMVM.Models
{
    public class Playlist : BaseViewModel
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
