using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv11.DAL.MODELS
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [MaxLength(4)]
        public string Shortcut { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
