using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.DataAccess
{
    public partial class FileSystemPage : ContentPage
    {
        public FileSystemPage()
        {
            InitializeComponent();
            var fileSystem = DependencyService.Get<IFileSystem>();
        }
    }
}
