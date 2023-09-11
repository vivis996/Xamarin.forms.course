using System;
using System.Collections.Generic;

namespace xamarin.forms.course.Models
{
	public class ContactGroup : List<Contact>
	{
		public string Title { get; set; }
		public string ShortTitle { get; set; }

		public ContactGroup(string title, string shortTitle)
		{
			this.Title = title;
			this.ShortTitle = shortTitle;
		}
	}
}
