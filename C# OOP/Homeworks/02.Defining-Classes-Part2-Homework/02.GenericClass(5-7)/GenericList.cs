namespace _02.GenericClass_5_7_
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class GenericList<T> where T : IComparable, new()
    {
        // Constant fields
        const int DEFAULT_CAPACITY = 8;

        // Fields
        private T[] genericList;
        private int capacity;
        private int count = 0;

        // Constructors
        public GenericList()
            : this(DEFAULT_CAPACITY)
        { }

        public GenericList(int capacity)
        {
            this.capacity = capacity;
            this.genericList = new T[capacity];
        }

        // Properties
        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public int Count
        {
            get { return this.count; }
        }

        // Indexer for accessing element by index
        public T this[int index]
        {
            get
            {
                Validation(index);
                return this.genericList[index];
            }
            set
            {
                Validation(index);
                this.genericList[index] = value;
            }
        }

        // Metod Add
        public void Add(T element)
        {
            if (count == this.genericList.Length)
	        {
		        DoubleSize();
	        }
            this.genericList[count] = element;
            count++;
        }

        // Method RemoveElementByIndex
        public void RemoveByIndex(int index)
        {
            Validation(index);

            T[] result = new T[count - 1];

            for (int i = 0; i < index; i++)
            {
                result[i] = genericList[i];
            }
            for (int i = index + 1; i < count; i++)
            {
                result[i - 1] = genericList[i];
            }

            genericList = new T[count];
            count--;
            for (int i = 0; i < count; i++)
            {
                genericList[i] = result[i];
            }
        }

        // Method Insert Element
        public void InsertAtPosition(int index, T element)
        {
            Validation(index);

            if (count >= capacity)
            {
                DoubleSize();
            }
            count++;

            T[] result = new T[count + 1];

            for (int i = 0; i < count + 1 ; i++)
            {               
                if (i == index)
                {
                    result[i] = element;
                }
                else if ( i < index)
                {
                    result[i] = genericList[i];
                }
                else if ( i > index)
                {
                    result[i] = genericList[i - 1];
                }
            }            
            genericList = new T[count +1];
            for (int i = 0; i < count; i++)
            {
                genericList[i] = result[i];
            }
        }

        // Method Clear
        public void Clear()
        {
            this.genericList = new T[DEFAULT_CAPACITY];
            this.count = 0;
            this.capacity = 0;
        }

        // Method to find element by idnex
        public int IndexOf(T element)
        {
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                if (genericList[i].Equals(element))
                {
                    index = i;
                }
            }
            return index;
        }       

        // Method to validate input index
        public void Validation(int index)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentException(string.Format("Invalid index : {0}.It`s out of range.",index));
            }
        }

        // Method auto-grow functionallity
        private void DoubleSize()                           // Problem 6
        {
            int newSize = this.genericList.Length * 2;
            T[] newList = new T[newSize];

            for (int i = 0; i < count; i++)
            {
                newList[i] = this.genericList[i];
            }

            this.genericList = newList;
            this.Capacity = Capacity * 2;
        }

        // Create Generic Method Min<T>
        public T Min()
        {
            T min = this.genericList[0];
            for (int i = 0; i < count; i++)
            {
                if (this.genericList[i].CompareTo(min) < 0)
                {
                    min = genericList[i];
                }
            }
            return min;
        }

        // Create Generic Method Max<T>
        public T Max()
        {
            T max = this.genericList[0];
            for (int i = 0; i < count; i++)
            {
                if (this.genericList[i].CompareTo(max) > 0)
                {
                    max = genericList[i];
                }
            }
            return max;
        }

        // Override method ToString()
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                result.Append(genericList[i]);
                if (i < Count - 1)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();

        }
    }
}
