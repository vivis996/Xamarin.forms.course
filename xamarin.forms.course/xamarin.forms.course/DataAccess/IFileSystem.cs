using System;
using System.Threading.Tasks;

namespace xamarin.forms.course.DataAccess
{
	public interface IFileSystem
	{
		Task WriteTextAsync(string fileName, string text);
	}
}
