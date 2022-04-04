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
                return lastName + ", " + firstName;
            }
                }

        [Required(ErrorMessage = "Business Unit is Required")]
        [Display(Name = " Business Unit ")]
        
        
        public dlBusinessUnit businessUnit { get; set; }

        public enum dlBusinessUnit { 
        Boston = 1,
        Charlotte = 2,
        Chicago = 3, 
        Cincinnati = 4, 
        Cleveland = 5,
        Columbus = 6,
        Detroit = 7,
        India = 8,
        Indianapolis = 9,
        Louisville = 10,
        Miami = 11,
        Seattle = 12,
        St_Louis = 13,
        Tampa = 14
        }


        [Required]
        [Display(Name = " Title")]
        
        
        public dlTitle office { get; set; }
        public enum dlTitle { 
        National = 1,
        Partner = 2,
        Senior_Architect = 3,
        Architect = 4,
        Senior_Manager = 5,
        Manager = 6, 
        Senior_Consultant = 7,
        Consultant = 8
        }
       
        [Display(Name = "Hire Date")]
        [DisplayFormat(DataFormatString = "{0:dddd MMM d, yyyy}",
        ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is a required field")]
        public DateTime startDate { get; set; }
        public ICollection<RecognitionPage> Recognition { get; set; }


    }
}