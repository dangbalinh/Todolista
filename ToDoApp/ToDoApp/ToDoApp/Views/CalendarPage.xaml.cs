using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ToDoApp.Views
{	
	public partial class CalendarPage : ContentPage
	{	
		public CalendarPage ()
		{
			InitializeComponent ();
		}

        void calendar_DateSelectionChanged(System.Object sender, XCalendar.Models.DateSelectionChangedEventArgs e)
        {
            DisplayAlert("Date changed", calendar.SelectedDates.ToString(), "OK");

        }
    }
}

