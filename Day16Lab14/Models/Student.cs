using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Day16Lab14.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }

        [ForeignKey("House")] 
        public int HId { get; set; }
        public virtual House House { get; set; }
    }
}