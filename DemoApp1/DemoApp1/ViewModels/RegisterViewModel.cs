using Refractored.Xam.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            this.User = new User();
        }
        public User User { get; set; }

        public void SaveUser()
        {
            if (this.User.FirstName.Length < 1)
                throw new Exception("First name field is required.");            

            CrossSettings.Current.AddOrUpdateValue("FirstName", this.User.FirstName);
            CrossSettings.Current.AddOrUpdateValue("LastName", this.User.LastName);
            CrossSettings.Current.AddOrUpdateValue("Company", this.User.Company);
            CrossSettings.Current.AddOrUpdateValue("Email", this.User.Email);
            CrossSettings.Current.AddOrUpdateValue("Phone", this.User.Phone);
        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
