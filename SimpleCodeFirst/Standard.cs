using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCodeFirst
{
    class Standard
    {
        public Standard()
        {

        }
        public int StandardId { get; set; }
        public String StandardName { get; set; }
        public ICollection<Student> Students { get; set; }
    }

}
