using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BidOneTask.Models
{
    public class PersonViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please input first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please input last name")]
        public string LastName { get; set; }
    }
}
