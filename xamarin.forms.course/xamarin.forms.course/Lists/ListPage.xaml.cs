using System;
using System.Collections.Generic;
using xamarin.forms.course.Models;
using Xamarin.Forms;

namespace xamarin.forms.course.Lists
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            this.listView.ItemsSource = new List<Contact>
            {
                new Contact
                {
                    Name = "Daniel",
                    ImageUrl = "https://bit.ly/3P5irC6",
                },
                new Contact
                {
                    Name = "John",
                    ImageUrl = "https://bit.ly/3P5irC6",
                    Status = "Hey!, let's talk",
                },
            };
        }
    }
}
