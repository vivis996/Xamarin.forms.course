using SQLite;

namespace xamarin.forms.course.Models
{
    // To change the name table
    [Table("Recipes")]
    public class Recipe
    {
        // Add [Column("RecipeId")] If I want to change
        // the name of the column
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
    }
}
