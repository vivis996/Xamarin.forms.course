using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xamarin.forms.course.Layouts
{	
	public partial class RelativePage : ContentPage
	{	
		public RelativePage ()
		{
			InitializeComponent ();

			var relative = new RelativeLayout();
			Content = relative;

			var aquaBox = new BoxView { Color = Color.Aqua };
			relative.Children.Add(aquaBox,
				widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
				heightConstraint: Constraint.RelativeToParent(parent => parent.Height * 0.3));

			var silverBox = new BoxView { Color = Color.Silver };
			relative.Children.Add(silverBox,
				yConstraint: Constraint.RelativeToView(aquaBox, (relativeLayout, element) => element.Height + 20));
		}
	}
}
