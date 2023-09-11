using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Forms
{
    public partial class DateTimePage : ContentPage
    {
        public DateTimePage()
        {
            InitializeComponent();
            this.datePicker.MaximumDate = DateTime.Now.AddYears(1);
        }

        void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            // e.NewDate
            // e.OldDate
        }
    }
}
