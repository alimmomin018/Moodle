using Moodle.Models;
using Moodle.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Moodle
{
    public partial class MainPage : MasterDetailPage
    {
        private List<MenuItemList> menuList { get; set; }

        public MainPage()
        {
            InitializeComponent();
            menuList = new List<MenuItemList>();
            var profile = new MenuItemList() { Title = "Profile", Icon = "user.png", TargetType = typeof(ProfilePage) };
            var post = new MenuItemList() { Title = "Posts", Icon = "post.png", TargetType = typeof(PostPage) };
            var myCourse = new MenuItemList() { Title = "My Course", Icon = "mycourse.png", TargetType = typeof(MyCoursePage) };
            var grade = new MenuItemList() { Title = "Grades", Icon = "grade.png", TargetType = typeof(GradePage) };
            var upcomingEvent = new MenuItemList() { Title = "Upcoming Event", Icon = "upcomingevent.png", TargetType = typeof(UpcomingEventPage) };
            var campusMap = new MenuItemList() { Title = "Campus Map", Icon = "location.png", TargetType = typeof(CampusMapPage) };
            var schedule = new MenuItemList() { Title = "Schedule", Icon = "upcomingevent.png", TargetType = typeof(SchedulePage) };
            var logout = new MenuItemList() { Title = "Logout", Icon = "logout.png", TargetType = typeof(LogoutPage) };

            menuList.Add(profile);
            menuList.Add(post);
            menuList.Add(myCourse);
            menuList.Add(grade);
            menuList.Add(upcomingEvent);
            menuList.Add(campusMap);
            menuList.Add(schedule);
            menuList.Add(logout);            

            menuListView.ItemsSource = menuList;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PostPage)));
            this.BindingContext = new
            {
                UserName = "Jeff Bezos",
                Logo = "logo.png",
                UserEmail = "C0723234@mylambton.ca"
            };
        }

        private async void menuListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = (MenuItemList)e.SelectedItem;
            Type page = selectedItem.TargetType;
            if (page.FullName == "Moodle.Views.LogoutPage")
            {
                await Navigation.PopAsync();
            }
            else
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            }
            IsPresented = false;
        }

        protected override bool OnBackButtonPressed()
        {
            // If you want to continue going back
            
            

            // If you want to stop the back button
            return true;

        }
    }
}
