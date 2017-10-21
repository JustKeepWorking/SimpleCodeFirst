using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCodeFirst
{
    class Teacher
    {
        public Teacher()
        {

        }
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public ICollection<Student> Students { get; set; }
    }

}
