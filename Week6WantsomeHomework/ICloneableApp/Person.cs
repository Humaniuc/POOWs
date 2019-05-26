using System;

namespace ICloneableApp
{
    class Person : ICloneable
    {
        private readonly string name;
        private readonly int cnp;
        private Contact contact;
        
        internal string Name { get; private set; }
        internal int CNP { get; private set; }
        internal double Grade { get; set; }
        internal Person(string name, int cnp, Contact contact)
        {
            this.Name = name;
            this.CNP = cnp;
            this.contact = contact;
        }
        public object Clone()
        {
            Person human = (Person)this.MemberwiseClone();
            human.contact = new Contact(this.contact.Tel, this.contact.Email);
            return human;
        }

        public override string ToString()
        {
            return $"{Name} has CNP {CNP}, Grade {Grade} and Contact: tel. {contact.Tel} email {contact.Email}";
        }
    }
}
