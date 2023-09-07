using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Extensions
{
    public partial class DateCell : ViewCell
    {
        public static readonly BindableProperty LabelProperty =
                               BindableProperty.Create(nameof(Label), typeof(string), typeof(DateCell));

        public string Label
        {
            get
            {
                return (string)GetValue(LabelProperty);
            }
            set
            {
                SetValue(LabelProperty, value);
            }
        }

        public DateCell()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
    }
}
