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
        public string CustomerFullName { get; set; }
        [PersonalData]
        public DateTime CustomerDOB { get; set; }
        [PersonalData]
        public string UserRole { get; set; }

    }

}
