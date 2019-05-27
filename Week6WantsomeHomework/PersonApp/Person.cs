namespace PersonApp
{
    class Person
    {
        private readonly string name;
        private int? age;

        internal string Name { get; private set; }
        internal int? Age { get; set; }

        internal Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Name: " + Name + "\nAge: " + (Age == null ? "Age isn't set" : $"{Age}");
        }
    }
}