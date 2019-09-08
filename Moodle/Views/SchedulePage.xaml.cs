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
	public partial class SchedulePage : ContentPage
	{
        private ObservableCollection<Schedule> _schedules { get; set; }

        public SchedulePage ()
		{
			InitializeComponent();
            _schedules = new ObservableCollection<Schedule>
            {
                new Schedule{ CourseCode = "2018F_CSD_2206_5", CourseTitle = "Advanced Infrastructure Security", Date = "2018-10-23" , Professor="Hessam A", Time="2:30PM - 5:30PM", RoomNumber = "B226" },
                new Schedule{CourseCode = "2018F_CSD_2206_5", CourseTitle = "Programming C# .NET", Date = "2018-10-21" , Professor="Hessam A", Time="9:30PM - 1:30PM", RoomNumber = "B226" },
                new Schedule{CourseCode = "2018F_CSD_2206_5", CourseTitle = "Advanced Infrastructure Security", Date = "2018-10-21" , Professor="Hessam A", Time="1:30PM - 5:30PM", RoomNumber = "B226" },
                new Schedule{CourseCode = "2018F_CSD_2206_5", CourseTitle = "Programming C# .NET", Date = DateTime.Today.Date.ToShortDateString(), Professor="Hessam A", Time="2:30PM - 5:30PM", RoomNumber = "B226" },
                
                new Schedule{ CourseCode = "2018F_CSD_2206_5", CourseTitle = "Web Technologies I", Date = DateTime.Today.Date.ToShortDateString(), Professor="Hessam A", Time="9:30PM - 1:30PM", RoomNumber = "B226" },
                new Schedule{ CourseCode = "2018F_CSD_2206_5",CourseTitle = "Advanced Infrastructure Security", Date = DateTime.Today.Date.ToShortDateString(), Professor="Hessam A", Time="1:30PM - 5:30PM", RoomNumber = "B226" },
                new Schedule {CourseCode = "2018F_CSD_2206_5", CourseTitle = "Programming C# .NET", Date = "2018-11-17", Professor = "Hessam A", Time = "9:30PM - 1:30PM", RoomNumber = "B226" },
                new Schedule {CourseCode = "2018F_CSD_2206_5", CourseTitle = "Programming C# .NET", Date = "2018-11-17", Professor = "Hessam A", Time = "1:30PM - 5:30PM", RoomNumber = "B226" },
                new Schedule {CourseCode = "2018F_CSD_2206_5", CourseTitle = "Advanced Infrastructure Security", Date = "2018-11-18", Professor = "Hessam A", Time = "2:30PM - 5:30PM", RoomNumber = "B226" },
                new Schedule { CourseCode = "2018F_CSD_2206_5",CourseTitle = "Web Technologies I", Date = "2018-11-19", Professor = "Hessam A", Time = "2:30PM - 5:30PM", RoomNumber = "B226" },
            }; 


            scheduleListView.ItemsSource = _schedules.Where(x=> DateTime.Parse(x.Date.ToString()) >= DateTime.Today.Date);
		}

        private void scheduleListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            scheduleListView.SelectedItem = null;
        }

        private void loadFullList_Tapped(object sender, EventArgs e)
        {
            //load entire list
            loadList.IsVisible = false;
            scheduleListView.ItemsSource = _schedules;
        }

        private void scheduleListView_Refreshing(object sender, EventArgs e)
        {
            scheduleListView.IsRefreshing = false;
        }
    }
}