using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjects
{
    public class UserBusinessObject
    {
        public int UserID { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is required ")]
        public string UserName { get; set; }
        [Display(Name = "User Address")]
        [Required(ErrorMessage = "User Address is required ")]
        public string UserAddress { get; set; }
        [Display(Name = "User Email")]
        [Required(ErrorMessage = "User Email is required ")]
        [EmailAddress(ErrorMessage = "Please Enter a valid Email Address")]
        public string UserEmail { get; set; }
        [Display(Name = "User Phone")]
        [Required(ErrorMessage = "User Phone is required ")]
        public string UserPhone { get; set; }

    }
}
