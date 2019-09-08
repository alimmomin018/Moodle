using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Moodle.Models
{
    public class Post
    {
        public string OwnerImage { get; set; }
        public string Title { get; set; }
        public string PostedBy { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
