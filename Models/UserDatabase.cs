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
        public string lastName { get; set; }

        [Required]
        public string firstName { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        public string fullName { get
            {
                return lastName + "," + firstName;
            }
                }

        [Required]
        public string department { get; set; }

        [Required]
        public string office { get; set; }
            public enum OfficeLocation
            {
                Boston = 1,
                Charlotte = 2,
                Chicago = 3,
                Cleveland = 4,
                Cincinnati = 5,
                Columbus = 6,
                Detroit = 7,
                India = 8,
                Indianapolis = 9,
                Lousiville = 10,
                Miami = 11,
                Seattle = 12,
                StLouis = 13,
                Tampa = 14,
                

            }
        

        [Required]
        public DateTime startDate { get; set; }


    }
}