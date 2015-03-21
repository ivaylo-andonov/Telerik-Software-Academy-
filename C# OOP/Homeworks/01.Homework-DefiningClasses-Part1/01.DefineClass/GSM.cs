namespace _01.DefineClass
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class GSM
    {
        //Const Fields
        private const string DEFAULT_MODEL = "Future Phone Z1000";
        private const Manufacturer DEFAULF_MANUFACTURER = Manufacturer.Unknown;
        private const double DEFAULT_PRICE = 1000;
        private const string DEFAULT_OWNER = "Ivaylo Andonov";

        public  const double fixedPhoneCallPrice = 0.37;

        // Fields
        private readonly static GSM iphone4S =                      // problem 6
            new GSM("Iphone 4S",Manufacturer.APPLE,699.00,
            "Телерик Академов", new Display(8.2,5.5,32000000),
            new Battery(BatteryType.Li_Poly, 32, 6));                

        private string model;                                        // problem 1
        private Manufacturer manufacturer;                           // problem 1
        private double price;                                        // problem 1
        private string owner;                                        // problem 1
        private Display displayOfGsm;                                // problem 1
        private Battery batteryOfGsm;                                // problem 1
        private List<Call> callHistory;                              // problem 9

        //Constructors with 0,1,2,3,4,5 or 6 parameters . The empty one inharite default const fields
        public GSM()
            :this(DEFAULT_MODEL,DEFAULF_MANUFACTURER,DEFAULT_PRICE,DEFAULT_OWNER,new Display(),new Battery(),new List<Call>())
        {
        }

        public GSM(string someModel)
        {
            this.Model = someModel;
        }

        public GSM(string someModel,Manufacturer someManufacturer)
            :this(someModel)
        {
            this.manufacturer = someManufacturer;
        }

        public GSM(string someModel, Manufacturer someManufacturer, double somePrice)
            : this(someModel, someManufacturer)
        {
            this.Price = somePrice;
        }
        public GSM(string someModel, Manufacturer someManufacturer, double somePrice,string someOwner)
            : this(someModel, someManufacturer,somePrice)
        {
            this.Owner = someOwner;
        }

        public GSM(string someModel, Manufacturer someManufacturer, double somePrice, string someOwner,Display someDisplay)
            : this(someModel, someManufacturer, somePrice,someOwner)
        {
            this.Display = someDisplay;
        }
        public GSM(string someModel, Manufacturer someManufacturer, double somePrice, string someOwner, Display someDisplay,Battery someBattery)
            : this(someModel, someManufacturer, somePrice, someOwner,someDisplay)
        {
            this.Battery = someBattery;
        }
        public GSM(string someModel, Manufacturer someManufacturer, double somePrice, string someOwner, Display someDisplay, Battery someBattery,List<Call> history)
            : this(someModel, someManufacturer, somePrice, someOwner, someDisplay,someBattery)
        {
            this.CallHistory = new List<Call>();
        }

        // Properties  Problem 5
        public  static GSM Iphone4S     // Property for static field Iphone4S , no need to set cuz it is readonly,static,non-changeble
        {
            get { return iphone4S; }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty.");
                }
                this.model = value;
            }
        }

        public Manufacturer Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be at least zero.");
                }
                else this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The owner`s name should be at least 2 letters");
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.batteryOfGsm;
            }
            private set
            {
                this.batteryOfGsm = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.displayOfGsm;
            }
            private set
            {
                this.displayOfGsm = value;
            }
        }

        public List<Call> CallHistory       // Problem 9
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }

        // Override method ToString()
        public override string ToString()     // Problem 4
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(new string('=', 50) + "\n" + "Mobile phone:\n" + new string('-', 13) + "\n");
            result.AppendLine(string.Format("Model : {0}", this.model));
            result.AppendLine(string.Format("Manifacturer : {0}", this.manufacturer));
            result.AppendLine(string.Format("Price : {0}", this.price));
            result.AppendLine(string.Format("Owner : {0}", this.owner));
            result.AppendLine("\nBattery specifications:");
            result.AppendLine(new string('-',23));
            result.AppendLine(string.Format("{0}",this.Battery));
            result.AppendLine("\nDisplay specifications:");
            result.AppendLine(new string('-', 23));
            result.AppendLine(string.Format("{0}", this.Display));

            return result.ToString();
        }

        // Create methods Add/Remove/Clear calls in history     Problem 10
        public List<Call> AddCalls(Call call)
        {
            this.CallHistory.Add(call);
            return this.CallHistory;
        }

        public List<Call> RemoveCalls(Call call)
        {
            this.CallHistory.Remove(call);
            return this.CallHistory;

        }
        public List<Call> ClearCallHistory()
        {
            this.CallHistory.Clear();
            return this.CallHistory;
        }
        
        // Create method Calculate Price of calls    Problem 11

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            double totalDuration = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalDuration += callHistory[i].Duration;
            }
            totalPrice = totalDuration * fixedPhoneCallPrice;

            return totalPrice;
        }

        //Create print method
        public string PrintCallHistory()
        {
            return string.Format("Calls History:\n{0}", string.Join(Environment.NewLine, this.callHistory));
        }

    }

    public enum Manufacturer    // Problem 3 ( additional)
    {
        HTC,
        SAMSUNG,
        LG,
        MOTOROLA,
        APPLE,
        NOKIA,
        SONY,
        LENOVO,
        BLACKBERRY,
        Unknown
    }
}
