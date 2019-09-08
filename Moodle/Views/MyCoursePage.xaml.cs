using Moodle.Models;
using Moodle.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Moodle.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCoursePage : ContentPage
	{
		public MyCoursePage ()
		{
			InitializeComponent ();
		}

        private void courseListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedSubject = e.Item as Grade;
            var gvm = BindingContext as GradeViewModel;
            gvm?.ShoworHideSubject(selectedSubject);
        }
    }
}