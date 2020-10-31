using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Profile.Domain.CreateProfileWorkflow
{
    public struct Profile
    {
        [Required]
        public string name { get; private set; }
        public string middle_name { get; set; }
        [Required]
        public string last_name { get; private set; }
        [Required]
        [EmailAddress]
        public string email_address { get; private set; }

        public Profile(string firstName, string middleName, string lastName, string emailAddress)
        {
            name = firstName;
            last_name = lastName;
            email_address = emailAddress;
            middle_name = middleName;
        }
    }
}
