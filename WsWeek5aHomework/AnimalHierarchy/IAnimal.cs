namespace AnimalHierarchy
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public char Sex { get; set; }

        public abstract string Speak();
    }
}
