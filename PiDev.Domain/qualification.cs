﻿

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiDev.Domain
{
    [Table("qualification")]
    public class qualification
    {

        [StringLength(255)]
        [Key]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int idJobOffer { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        [StringLength(255)]
        public String state { get; set; }
        public Nullable<int> cin { get; set; }
        public virtual jobOffer JobOffer { get; set; }
        public virtual employe Employe { get; set; }
    }
   
    public enum State
    {
        NotAquired, Learning, Mastered
    }
  
}

