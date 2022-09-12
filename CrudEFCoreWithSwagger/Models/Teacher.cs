using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEFCoreWithSwagger.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "Teacher Name is required")]

        [Column(TypeName = "varchar(255)")]
        public string TeacherName { get; set; }

        [Required(ErrorMessage = "Teacher Gender is required")]
        [Column(TypeName = "varchar(255)")]
        public string TeacherGender { get; set; }

    }
}
