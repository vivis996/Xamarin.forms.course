using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace xamarin.forms.course.Models
{
    public class Post : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                if (this._title == value)
                    return;

                this._title = value;

                this.OnPropertyChanged();
            }
        }
        public string Body { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
