using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student : IComparable<Student>
    {
        public int StudentId { get; set; }
        public String StudentName { get; set; }

        public int StandardId { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student other)
        {
            if (this.StudentName.Length >= other.StudentName.Length)
                return 1;
            return 0;
        }
    }
}
