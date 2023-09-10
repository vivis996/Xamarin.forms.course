﻿using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin.forms.course.MVVM.ViewModels
{
    public interface IPageService
    {
        Task PushAsync(Page page);
        Task<bool> DisplayAlert(string title, string message, string ok, string cancel);
    }
}
