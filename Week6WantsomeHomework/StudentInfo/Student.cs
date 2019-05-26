using System;

namespace StudentInfo
{
    class Student
    {
        private readonly string firstName;
        private readonly string middleName;
        private readonly string lastName;
        private readonly int ssn;
        private string mobilePhone;
        
        internal Student(string fName, string mName, string lName, int ssn)
        {
            FirstName = fName;
            MiddleName = mName;
            LastName = lName;
            SSN = ssn;
        }
        internal string FirstName { get; private set; }
        internal string MiddleName { get; private set; }
        internal string LastName { get; private set; }
        internal int SSN { get; private set; }
        internal string address { get; set; }
        internal string MobilePhone
        {
            get { return mobilePhone; }
            set
            {
                foreach(char c in value)
                {
                    if (c < 48 || c > 57)
                    {
                        Console.WriteLine("Not a valid value for phone number");
                        return;
                    }
                }
                mobilePhone = value;
            }
        }
        internal string Email { get; set; }
        internal string Course { get; set; }
        internal string Specialty { get; set; }
        internal string Faculty { get; set; }
        internal string University { get; set; }

        public override bool Equals(object obj)
        {
            if(obj is Student)
            {
                return this.SSN == (obj as Student).SSN;
            }
            return false;
        }

        public override string ToString()
        {
            return $@"
            Name: {FirstName} + {MiddleName} + {LastName}
            SSN: {SSN}
            address: {address}
            contact: tel. {MobilePhone} email {Email}
            University: {University}
            Faculty: {Faculty}
            Course: {Course}" + "\n";
        }

        public override int GetHashCode()
        {
            return this.SSN;
        }

        public static bool operator == (Student s1, Student s2)
        {
            return s1.Equals(s2);
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return !s1.Equals(s2);
        }
    }
}
