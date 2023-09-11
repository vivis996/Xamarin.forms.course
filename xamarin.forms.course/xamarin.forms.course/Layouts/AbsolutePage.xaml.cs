using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Layouts
{
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();

            var absolute = new AbsoluteLayout();
            Content = absolute;

            var aquaBox = new BoxView { Color = Color.Aqua };
            absolute.Children.Add(aquaBox, new Rectangle(0, 0, 1, 1),
                                  AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.HeightProportional);
        }
    }
}
