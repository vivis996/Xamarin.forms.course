﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course
{	
	public partial class StackPage : ContentPage
	{	
		public StackPage ()
		{
			InitializeComponent ();

			var layout = new StackLayout
			{
				Spacing = 40,
				Padding = new Thickness(0, 20, 0, 0),
				Orientation = StackOrientation.Horizontal,
			};
			layout.Children.Add(new Label { Text = "Label 1" });

			Content = layout;
		}
	}
}
