using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace HelperClasses
{
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentId == y.StudentId && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;
            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
