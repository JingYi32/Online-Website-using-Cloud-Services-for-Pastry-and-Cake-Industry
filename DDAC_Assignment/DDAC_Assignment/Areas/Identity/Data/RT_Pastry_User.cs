using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DDAC_Assignment.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the RT_Pastry_User class
    public class RT_Pastry_User : IdentityUser
    {
        [PersonalData]
        public string user_name { get; set; }
        public string user_email { get; set; }
        public string user_contact_no { get; set; }
        public DateTime user_dob { get; set; }
        public string user_gender { get; set; }
        public string user_username { get; set; }
        public string user_password { get; set; }
        public string user_role { get; set; }

    }
}
