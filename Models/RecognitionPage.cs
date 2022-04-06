using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Centric_Team_3.Models
{
    public class RecognitionPage
    {
        [Key]
        public int ID { get; set; }
        public string myName { get; set; }
        [Required(ErrorMessage = "Select an employee to recognize")]
        [Display(Name = "Recognizee")]
        public Guid recognitionID { get; set; }
        public Guid giver { get; set; }
        [ForeignKey("recognitionID")]
        public virtual UserDatabase recievee { get; set; }
        [ForeignKey("giver")]
        public virtual UserDatabase Giver { get; set; }

        [Required(ErrorMessage = "Core Values Indicator is Required")]
        [Display(Name = " Core Values Indicator ")]


        public dlCoreValues coreValues { get; set; }

        public enum dlCoreValues
        {
            Stewardship = 1,
            Culture = 2,
            [Display(Name = "Delivery Excellence")]
            Delivery_Excellence = 3,
            Innovation = 4,
            [Display(Name = "Greater Good")]
            Greater_Good = 5,
            [Display(Name = "Integrity and Openess")]
            Integrity_and_Openess = 6,
            Balance = 7
        }

        [Required(ErrorMessage = "Reward is Required")]
        [Display(Name = " Reward ")]


        public dlReward reward { get; set; }

        public enum dlReward
        {
            Excellent = 1,
            [Display(Name = " Good Job ")]
            Good_Job = 2,
            [Display(Name = " Nice Work ")]
            Nice_Work = 3  
        }
    }
    
}