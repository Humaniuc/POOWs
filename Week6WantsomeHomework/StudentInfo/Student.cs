using System;

namespace StudentInfo
{
    class Student : IComparable, ICloneable
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
        internal string Address { get; set; }
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
            address: {Address}
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
        public int CompareTo(object obj)
        {
            int retur = 0;
            if(obj is Student)
            {
                Student student = obj as Student;
                int count;
                if(student.FirstName.Length > this.FirstName.Length)
                {
                    count = this.FirstName.Length;
                }
                else
                {
                    count = student.FirstName.Length;
                }

                for(int i = 0; i < count; i++)
                {
                    if(this.FirstName[i] < student.FirstName[i] )
                    {
                        retur = -1;
                        break;
                    }
                    else if(this.FirstName[i] > student.FirstName[i])
                    {
                        retur = 1;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                retur = 0;

                if(retur == 0)
                {
                    if(this.SSN < student.SSN)
                    {
                        retur = -2;
                    }
                    else if (this.SSN > student.SSN)
                    {
                        retur = 2;
                    }
                }
            }
            return retur;
        }

        public object Clone()
        {
            Student stud = this.MemberwiseClone() as Student;
            stud.FirstName = String.Copy(this.FirstName);
            stud.MiddleName = String.Copy(this.MiddleName);
            stud.LastName = String.Copy(this.LastName);
            stud.Address = String.Copy(this.Address);
            stud.MobilePhone = String.Copy(this.MobilePhone);
            stud.Email = String.Copy(this.Email);
            stud.Course = String.Copy(this.Course);
            stud.Faculty = String.Copy(this.Faculty);
            stud.University = String.Copy(this.University);
            return stud;
        }
    }
}
