namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, uint age, char sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public override string Speak()
        {
            return "Miau";
        }
    }
}
