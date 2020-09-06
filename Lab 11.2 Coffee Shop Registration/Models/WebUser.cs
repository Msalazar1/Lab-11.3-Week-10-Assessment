using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_11._2_Coffee_Shop_Registration.Models
{
    public class WebUser
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string BDay { get; set; }
        public string State { get; set; }
        public string FavoriteColor { get; set; }
        public string PhoneNumber { get; set; }
        

    }
}