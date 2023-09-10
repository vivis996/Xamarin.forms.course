using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace xamarin.forms.course.MMVM.Models
{
    public class Playlist : INotifyPropertyChanged
    {
        public string Title { get; set; }

        private bool _isFavorite;
        public bool IsFavorite
        {
            get { return this._isFavorite; }
            set
            {
                if (this._isFavorite == value)
                    return;

                this._isFavorite = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(Color));
            }
        }

        public Color Color
        {
            get { return this.IsFavorite ? Color.Pink : Color.Black; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
