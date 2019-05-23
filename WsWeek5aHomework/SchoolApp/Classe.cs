using System.Collections.Generic;

namespace SchoolApp
{
    class Classe
    {
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();

        internal List<Student> Students { get; set; }
        internal List<Teacher> Teachers { get; set; }

        public Classe(List<Student> students, List<Teacher> teachers)
        {
            Students = students;
            Teachers = teachers;
        }
    }
}
