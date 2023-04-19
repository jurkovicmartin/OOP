using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv11.DAL.MODELS
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [MaxLength(50)]
        public string Firstname { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
