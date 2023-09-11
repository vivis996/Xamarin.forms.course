using SQLite;
namespace xamarin.forms.course.DataAccess.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
