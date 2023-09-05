using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Lists
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            var names = new List<string>
            {
                "Daniel",
                "John",
                "Doe",
            };

            this.listView.ItemsSource = names;
        }
    }
}
