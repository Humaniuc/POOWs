using System;

namespace GenericsHomeworkA
{
    public class GenericList<T> where T : struct, IComparable<T>
    {
        private T[] arr;
        private uint idx;

        public GenericList(T[] array)
        {
            arr = new T[array.Length];
        }
        public T this[int index]
        {
            get
            {
                if (index >= idx)
                {
                    throw new IndexOutOfRangeException();
                }
                return arr[index];
            }
            set
            {
                if (index >= idx)
                {
                    throw new IndexOutOfRangeException();
                }
                arr[index] = value;
            }
        }
        private uint Count
        {
            get
            {
                return idx;
            }
            set
            {
                if (value > arr.Length)
                {
                    throw new IndexOutOfRangeException(message: "Index out of range (bigger than array size);");
                }
                idx = value;
            }
        }
        public void Add(T node)
        {
            arr[Count++] = node;
            if (Count == arr.Length)
            {
                arr = DoubleSize();
            }
        }
        public void RemoveByValue(T node)
        {
            try
            {
                int index = Array.IndexOf<T>(arr, node);
                if (index < --Count)
                {
                    Array.Copy(arr, index + 1, arr, index, Count - index);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public int ElementAtByValue(T node)
        {
            int index = -1;
            try
            {
                index = Array.IndexOf<T>(arr, node);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return index;
        }
        public T ElementAt(uint index)
        {
            return arr[index];
        }
        public void RemoveAt(uint index)
        {
            if (index < --Count)
            {
                Array.Copy(arr, index + 1, arr, index, Count - index);
            }
        }
        public void InsertAt(uint index, T node)
        {
            if (index < --Count)
            {
                Array.Copy(arr, index, arr, index + 1, ++Count - index);
                Count++;
                arr[index] = node;
            }
            else if (index == arr.Length)
            {
                arr = DoubleSize();
            }
            else
            {
                throw new IndexOutOfRangeException("Index to insert out of range of list");
            }
        }
        public void ClearList()
        {
            Array.Clear(arr, 0, (int)Count);
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Count; i++)
            {
                str += $"{this.arr[i]} ";
            }
            return str;
        }

        public T[] DoubleSize()
        {
            T[] newArr = null;
            if (Count >= arr.Length)
            {
                newArr = new T[arr.Length * 2];
            }
            Array.Copy(arr, newArr, arr.Length);
            return newArr;
        }

        public T Min() 
        {
            T min = arr[0];
            for(int i = 1; i < Count; i++)
            {
                if(min.CompareTo(arr[i]) > 0)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = arr[0];
            for (int i = 1; i < Count; i++)
            {
                if (max.CompareTo(arr[i]) < 0)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
