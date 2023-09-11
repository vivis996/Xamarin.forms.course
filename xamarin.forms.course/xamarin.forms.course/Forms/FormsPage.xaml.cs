using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Forms
{
    public partial class FormsPage : ContentPage
    {
        public FormsPage()
        {
            InitializeComponent();
        }

        void Entry_Completed(object sender, EventArgs e)
        {
            this.label.Text = "Completed";
        }

        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.label.Text = e.NewTextValue;
        }
    }
}
