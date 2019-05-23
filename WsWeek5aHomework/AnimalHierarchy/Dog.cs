namespace AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, uint age, char sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public override string Speak()
        {
            return "Ham ham";
        }
    }
}
