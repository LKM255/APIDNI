using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDNI.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nomber { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string DNI { get; set; }
    }
}
