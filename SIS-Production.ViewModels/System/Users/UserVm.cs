using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SIS_Production.ViewModels.System.Users
{
    public class UserVm
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string Division { get; set; }

        public string Department { get; set; }
        public string Section { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
    }
}
