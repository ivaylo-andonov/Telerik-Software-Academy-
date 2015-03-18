namespace _01.DefineClass
{
    using System;

    public class Call
    {
        // FIelds 
        private DateTime date;
        private string dialedPhoneNumber;
        private double durationOfCall;

        //Constructor
        public Call(DateTime date, string dialedNumber, double durationOfCall)
        {
            this.Date = date;
            this.DialedPhoneNum = dialedNumber;
            this.Duration = durationOfCall;
        }

        //Properties

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public string DialedPhoneNum
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The phone number should be not empty");
                }
                this.dialedPhoneNumber = value;
            }
        }
        public double Duration
        {
            get
            {
                return this.durationOfCall;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The duration should be more than 0 sec");
                }
                else this.durationOfCall = value;
            }
        }
        // Ovveride ToString()
        public override string ToString()
        {
            return string.Format("Date and time: {0:dd/MM/yyy, H:mm:ss} h;  Duration: {1} seconds;  Dialed number: {2}",
                this.Date, this.Duration, this.DialedPhoneNum);
        }
    }
}
