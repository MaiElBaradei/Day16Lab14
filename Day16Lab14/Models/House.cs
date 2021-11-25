using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day16Lab14.Models
{
    public class House
    {
        [Key]
        public int HId { get; set; }
        public string HName { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}