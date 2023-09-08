using System;
using System.IO;
using System.Threading.Tasks;
using xamarin.forms.course.DataAccess;
using Xamarin.Forms;

[assembly: Dependency(typeof(xamarin.forms.course.iOS.DataAccess.FileSystem))]
namespace xamarin.forms.course.iOS.DataAccess
{
    public class FileSystem : IFileSystem
    {
        public async Task WriteTextAsync(string fileName, string text)
        {
            var docksPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(docksPath, fileName);
            using (var writer = File.CreateText(path))
            {
                await writer.WriteAsync(text);
            }
        }
    }
}
