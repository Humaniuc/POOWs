namespace SchoolApp
{
    class Discipline
    {
        private string name;
        private uint lessonNumber;
        private uint exNumber;

        internal string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    System.Console.WriteLine("Name cannot be null");
                }
            }
        }

        internal uint LessonNum { get; set; }
        internal uint ExNum { get; set; }

        public Discipline(string name, uint nrLessons, uint nrExercices)
        {
            Name = name;
            LessonNum = nrLessons;
            exNumber = nrExercices;
        }
        public Discipline(string name, uint nrLessons)
        {
            Name = name;
            LessonNum = nrLessons;
        }
    }
}
