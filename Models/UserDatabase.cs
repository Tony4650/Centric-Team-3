using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Centric_Team_3.Models
{
    public class UserDatabase
    {
        public Guid ID { get; set; }

        [Required]
        [Display(Name = " Last Name ")]
        [RegularExpression("^([a-zA-Z']+)$", ErrorMessage = "System dos not allow digits or special characters in Last Name")]
        public string lastName { get; set; }
        
        [Required]
        [Display(Name = " First Name")]
        [RegularExpression("^([a-zA-Z']+)$", ErrorMessage = "System dos not allow digits or special characters in First Name")]
        public string firstName { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        public string fullName { get
            {
                return lastName + "," + firstName;
            }
                }

        [Required]
        [Display(Name = " Business Unit ")]
        [RegularExpression("^([a-zA-Z']+)$", ErrorMessage = "System dos not allow digits or special characters in Department")]
        public string businessUnit { get; set; }
        
        [Required]
        [Display(Name = " Office")]
        [RegularExpression("^([a-zA-Z']+)$", ErrorMessage = "System dos not allow digits or special characters in Office")]
        public string office { get; set; }
       
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:dddd MMM d, yyyy}",
        ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is a required field")]
        public DateTime startDate { get; set; }
        

    }
}