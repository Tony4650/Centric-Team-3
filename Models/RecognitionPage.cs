using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Centric_Team_3.Models
{
    public class RecognitionPage
    {
        [Key]
        public int RecognitionID { get; set; }
        public string myName { get; set; }
        public Guid ID { get; set; }
        public virtual UserDatabase Users { get; set; }

        [Required(ErrorMessage = "Core Values Indicator is Required")]
        [Display(Name = " Core Values Indicator ")]


        public dlCoreValues coreValues { get; set; }

        public enum dlCoreValues
        {
            Stewardship = 1,
            Culture = 2,
            Delivery_Excellence = 3,
            Innovation = 4,
            Greater_Good = 5,
            Integrity_and_Openess = 6,
            Balance = 7
        }

        [Required(ErrorMessage = "Reward is Required")]
        [Display(Name = " Reward ")]


        public dlReward reward { get; set; }

        public enum dlReward
        {
            Excellent = 1,
            Good_Job = 2,
            Nice_Work = 3  
        }
    }
    
}