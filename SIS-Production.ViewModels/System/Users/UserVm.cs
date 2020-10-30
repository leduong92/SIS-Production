using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SIS_Production.ViewModels.System.Users
{
    public class UserVm
    {
        public Guid Id { get; set; }

        [Display(Name = "Tên")]
        public string FirstName { get; set; }

        [Display(Name = "Họ")]
        public string LastName { get; set; }

        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Tài khoản")]
        public string UserName { get; set; }

        [Display(Name = "Division")]
        public string Division { get; set; }

        [Display(Name = "Department")]
        public string Department { get; set; }
        [Display(Name = "Section")]
        public string Section { get; set; }
        [Display(Name = "Di động")]
        public string Phone { get; set; }
        [Display(Name = "Nhà máy")]
        public string Location { get; set; }

        [Display(Name = "Ngày tạo")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
}
