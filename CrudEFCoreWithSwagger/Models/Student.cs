using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEFCoreWithSwagger.Models
{
    public class Student
    {
        
        [Key] //specify which column for primary key
        public int StudentId { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string StudentName { get; set; }
   
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Roll { get; set; }
    }
}
