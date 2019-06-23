using System.Collections;
using System.Collections.Generic;

namespace BitArray64
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong num;

        public BitArray64()
        {
            num = 0b00000000000000000000000000000000;
        }
        public ulong Num { get; set; }
        public IEnumerator<int> GetEnumerator()
        {
            yield return (int) num | (0b1 << 1);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            if (obj is BitArray64)
            {
                return (obj as BitArray64).num == num;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (int)num;
        }
        //public static bool operator [](int number)
        //{
        //    return (num << iterator) & number;
        //}
        public static bool operator == (BitArray64 num1, object num2)
        {
            return num1.Equals(num2);
        }
        public static bool operator != (BitArray64 num1, object num2)
        {
            return !num1.Equals(num2);
        }


    }
}
