namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(string name, uint age, char sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public override string Speak()
        {
            return "Oac Oac";
        }
    }
}
