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
	public partial class PostPage : ContentPage
	{
        private ObservableCollection<Post> _posts { get; set; }

        public PostPage ()
		{
			InitializeComponent ();
            _posts = new ObservableCollection<Post>
            {
                new Post{ OwnerImage="",
                    Date = DateTime.Today ,
                    Title="Transfer Credit Request",
                    Description =@"<html><body><p>Good afternoon Students,</p><br/> <p>Please be advised that Transfer Credit Applications for returning students will start being accepted as of Monday, November 19th, 2019.The deadline for all Transfer Credit Applications is December 13th and no application will be accepted after this date.All applications must be submitted to the 4th floor Reception Desk for consideration.Please feel free to visit Student Services for any clarification regarding the Application. </p></body></html>" ,
                    PostedBy = "by Student Services @Lambton College in Toronto " + DateTime.Today
                },
                new Post{ OwnerImage="",
                    Date = DateTime.Today,
                    Title = "Dec 3rd TechToronto sponsored tickets sold out!",
                    Description = @"<html><body><p>Good afternoon Students,</p><br/> <p>Please be advised that Transfer Credit Applications for returning students will start being accepted as of Monday, November 19th, 2019.The deadline for all Transfer Credit Applications is December 13th and no application will be accepted after this date.All applications must be submitted to the 4th floor Reception Desk for consideration.Please feel free to visit Student Services for any clarification regarding the Application. </p></body></html> " ,
                    PostedBy = "by Coop and Carrer Services @Lambton College in Toronto " + DateTime.Today
                },new Post{ OwnerImage="",
                    Date = DateTime.Today ,
                    Title="Transfer Credit Request",
                    Description =@"<html><body><p>Good afternoon Students,</p><br/> <p>Please be advised that Transfer Credit Applications for returning students will start being accepted as of Monday, November 19th, 2019.The deadline for all Transfer Credit Applications is December 13th and no application will be accepted after this date.All applications must be submitted to the 4th floor Reception Desk for consideration.Please feel free to visit Student Services for any clarification regarding the Application. </p></body></html>" ,
                    PostedBy = "by Student Services @Lambton College in Toronto " + DateTime.Today
                },
                new Post{ OwnerImage="",                    
                    Title = "Dec 3rd TechToronto sponsored tickets sold out!",
                    Description = @"<html><body><p>Good afternoon Students,</p><br/> <p>Please be advised that Transfer Credit Applications for returning students will start being accepted as of Monday, November 19th, 2019.The deadline for all Transfer Credit Applications is December 13th and no application will be accepted after this date.All applications must be submitted to the 4th floor Reception Desk for consideration.Please feel free to visit Student Services for any clarification regarding the Application. </p></body></html> " ,
                    PostedBy = "by Coop and Carrer Services @Lambton College in Toronto " + DateTime.Today
                }
            };
            postListView.ItemsSource = _posts;
        }

        private void postListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            postListView.SelectedItem = null;
        }

        private void searchPost_TextChanged(object sender, TextChangedEventArgs e)
        {
            postListView.IsVisible = true;
            errorMessage.IsVisible = false;
            var enteredText = e.NewTextValue;
            if (String.IsNullOrWhiteSpace(enteredText))
            {
                postListView.ItemsSource = _posts;
            }
            else
            {
                var result = _posts.Where(search => search.Title.ToLower().Contains(enteredText.ToLower()));
                if (result.Count() != 0)
                {
                    postListView.ItemsSource = result;
                }
                else
                {
                    errorMessage.IsVisible = true;
                    postListView.IsVisible = false;
                    errorMessage.Text = "No search result found";
                }
            }
        }

        private void postListView_Refreshing(object sender, EventArgs e)
        {
            postListView.IsRefreshing = true;
            _posts = new ObservableCollection<Post>
            {
                new Post{ OwnerImage="",
                    Date = DateTime.Today ,
                    Title="Transfer Credit Request",
                    Description =@"<html><body><p>Good afternoon Students,</p><br/> <p>Please be advised that Transfer Credit Applications for returning students will start being accepted as of Monday, November 19th, 2019.The deadline for all Transfer Credit Applications is December 13th and no application will be accepted after this date.All applications must be submitted to the 4th floor Reception Desk for consideration.Please feel free to visit Student Services for any clarification regarding the Application. </p></body></html>" ,
                    PostedBy = "by Student Services @Lambton College in Toronto " + DateTime.Today
                },
                new Post{ OwnerImage="",
                    Date = DateTime.Today,
                    Title = "Dec 3rd TechToronto sponsored tickets sold out!",
                    Description = @"<html><body><p>Good afternoon Students,</p><br/> <p>Please be advised that Transfer Credit Applications for returning students will start being accepted as of Monday, November 19th, 2019.The deadline for all Transfer Credit Applications is December 13th and no application will be accepted after this date.All applications must be submitted to the 4th floor Reception Desk for consideration.Please feel free to visit Student Services for any clarification regarding the Application. </p></body></html> " ,
                    PostedBy = "by Coop and Carrer Services @Lambton College in Toronto " + DateTime.Today
                },new Post{ OwnerImage="",
                    Date = DateTime.Today ,
                    Title="Transfer Credit Request",
                    Description =@"<html><body><p>Good afternoon Students,</p><br/> <p>Please be advised that Transfer Credit Applications for returning students will start being accepted as of Monday, November 19th, 2019.The deadline for all Transfer Credit Applications is December 13th and no application will be accepted after this date.All applications must be submitted to the 4th floor Reception Desk for consideration.Please feel free to visit Student Services for any clarification regarding the Application. </p></body></html>" ,
                    PostedBy = "by Student Services @Lambton College in Toronto " + DateTime.Today
                },
                new Post{ OwnerImage="",
                    Title = "Dec 3rd TechToronto sponsored tickets sold out!",
                    Description = @"<html><body><p>Good afternoon Students,</p><br/> <p>Please be advised that Transfer Credit Applications for returning students will start being accepted as of Monday, November 19th, 2019.The deadline for all Transfer Credit Applications is December 13th and no application will be accepted after this date.All applications must be submitted to the 4th floor Reception Desk for consideration.Please feel free to visit Student Services for any clarification regarding the Application. </p></body></html> " ,
                    PostedBy = "by Coop and Carrer Services @Lambton College in Toronto " + DateTime.Today
                }
            };
            postListView.ItemsSource = _posts;
            postListView.IsRefreshing = false;
        }
    }
}