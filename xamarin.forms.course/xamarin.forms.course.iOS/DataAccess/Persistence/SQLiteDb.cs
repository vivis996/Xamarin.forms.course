using System;
using System.IO;
using SQLite;
using xamarin.forms.course.DataAccess.Persistence;
using xamarin.forms.course.iOS.DataAccess.Persistence;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace xamarin.forms.course.iOS.DataAccess.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            const string DbName = "MySQLite.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, DbName);

            return new SQLiteAsyncConnection(path);
        }
    }
}
