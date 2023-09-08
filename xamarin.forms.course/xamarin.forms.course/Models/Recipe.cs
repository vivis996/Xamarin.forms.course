using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;

namespace xamarin.forms.course.Models
{
    // To change the name table
    [Table("Recipes")]
    public class Recipe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Add [Column("RecipeId")] If I want to change
        // the name of the column
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        private string _name;
        [MaxLength(255)]
        public string Name
        {
            get => this._name;
            set
            {
                if (this._name == value)
                    return;

                this._name = value;

                this.OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
