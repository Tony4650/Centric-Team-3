using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centric_Team_3.Models
{
    public class RecognitionPage
    {
        public int RecognitionID { get; set; }
        public string myName { get; set; }
        public int ID { get; set; }
        public virtual UserDatabase Users { get; set; }
    }
}