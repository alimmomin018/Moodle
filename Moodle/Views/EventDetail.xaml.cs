using Moodle.Interface;
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
	public partial class EventDetail : ContentPage, ISwipeCallBack
    {
		public EventDetail(string aTitle)
		{
			InitializeComponent ();
            
            this.BindingContext = new
            {
                Title = aTitle
            };
            SwipeListener swipeListener = new SwipeListener(detailLayout, this);
        }

        public async void onBottomSwipe(View view)
        {
            await Navigation.PopModalAsync();
            //if (view == lbl_swipe)
            //{
            //    lbl_result.Text = "OnBottomSwipe";
            //}
        }

        public void onLeftSwipe(View view)
        {
            //if (view == lbl_swipe)
            //{
            //    lbl_result.Text = "onLeftSwipe";
            //}
        }

        public void onNothingSwiped(View view)
        {
            //if (view == lbl_swipe)
            //{
            //    lbl_result.Text = "onNothingSwiped";
            //}
        }

        public void onRightSwipe(View view)
        {
            //if (view == lbl_swipe)
            //{
            //    lbl_result.Text = "onRightSwipe";
            //}
        }

        public void onTopSwipe(View view)
        {
            //if (view == lbl_swipe)
            //{
            //    lbl_result.Text = "onTopSwipe";
            //}
        }
    }
}