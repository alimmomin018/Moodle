using Moodle.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Moodle.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UpcomingEventPage : ContentPage
	{
        private ObservableCollection<UpcomingEvent> _upcomingEvents { get; set; }

        public UpcomingEventPage ()
		{
			InitializeComponent ();

            _upcomingEvents = new ObservableCollection<UpcomingEvent>
            {
                new UpcomingEvent{Title="Assignment 3", Subject="of Advanced Infrastructure Security", Date="due by "+DateTime.Now},
                new UpcomingEvent{Title="Assignment 4", Subject="of Advanced Infrastructure Security", Date="due by "+DateTime.Now},
                new UpcomingEvent{Title="Quiz 2", Subject="of Web Technologies I", Date="due by "+DateTime.Now},
                new UpcomingEvent{Title="Assignment 4", Subject="of Problem Solving/Program Logic", Date="due by "+DateTime.Now},
                new UpcomingEvent{Title="Assignment 5",  Subject = "of Problem Solving/Program Logic" ,Date="due by "+DateTime.Now},
            };

            upcomingEventListView.ItemsSource = _upcomingEvents;

        }

        private async void upcomingEventListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedEvent = (UpcomingEvent)e.SelectedItem;
            
            await Navigation.PushModalAsync(new NavigationPage(new EventDetail(selectedEvent.Title)));
        }
    }
}