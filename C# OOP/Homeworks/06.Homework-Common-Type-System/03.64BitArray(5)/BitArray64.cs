namespace _03._64BitArray_5_
{
    using System;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        //Constant fields
        private const byte Bits = 64;

        // Fields
        private ulong number;

        // Constructor
        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        //Properties
        public ulong Number
        {
            get { return this.number;  }
            set { this.number = value; }
        }

        // Indexer
        public byte this[int index]
        {
            get 
            {
                if (index < 0 || index >= Bits)
                {
                    throw new ArgumentOutOfRangeException("The index is out of range [0-63]");
                }
                return (byte)((this.Number >> index) & 1);
            }
            set
            {
                if (index < 0 || index >= Bits)
                {
                    throw new ArgumentOutOfRangeException("The index is out of range [0-63]");
                }
                if (value < 0 || value > 1)
                {
                      throw new ArgumentException("It should be 1 or 0");
                }
                if (((int)(this.Number >> index) & 1) != value)
                {
                    this.Number ^= (1ul << index);
                }
            }
        }

        //Operators

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        //Methods

        public override bool Equals(object obj)
        {
            var otherBitArray = obj as BitArray64;
            return this.Number.Equals(otherBitArray.Number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Bits; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.Number.GetHashCode();
        }

        // Print the binary number
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int index = 0; index < 64; index++)
            {
                result.Insert(0, ((this.Number >> index) & 1));
            }

            return result.ToString();
        }
    }
}
