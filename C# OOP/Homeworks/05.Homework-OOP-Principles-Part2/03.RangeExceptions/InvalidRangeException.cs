namespace _03.RangeExceptions
{
    using System;
    using System.Collections.Generic;

    public class InvalidRangeException<T>: ApplicationException
    {
        //Fields
        private T start;
        private T end;

        //Constructor
        public InvalidRangeException(T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        // Properties
        public T Start
        {
            get { return this.start; }
        }

        public T End
        {
            get { return this.end; }
        }

        //Override Method Message
        public override string Message
        {
            get
            {
                return string.Format("{0} is out of the allowed range [{1} - {2}]",
                    typeof (T).Name, this.Start, this.End);
            }
        }     
    }
}
