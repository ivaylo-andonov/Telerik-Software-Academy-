namespace _01.DefineClass
{
    using System;
    public class Battery
    {
        // Constant fields
        private const BatteryType DEFAULF_TYPE = BatteryType.Unknown;
        private const byte DEFAULT_IDDLE_HOURS = 32;
        private const byte DEFAULT_TALK_HOURS = 8;

        //Fields
        private BatteryType batteryType;
        private byte hoursOfIdle;
        private byte hoursOfTalk;

        // Constructors with 0,1,3 parameters
        
        public Battery()   // Empty constructor : default constructor with default const parameters
            :this(DEFAULF_TYPE, DEFAULT_IDDLE_HOURS, DEFAULT_TALK_HOURS)
        {
        }

        public Battery(BatteryType someBatteryType) // Constructor with params
        {
            this.BatteryType = someBatteryType;

        }

        public Battery(BatteryType someBatteryType, byte hoursIdle, byte hoursTalk)
            : this(someBatteryType)
        {
            this.IdleHours = hoursIdle;
            this.TalkHours = hoursTalk;
        }

        // Properties
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                this.batteryType = value;
            }
        }
        
        public byte IdleHours
        {
            get
            {
                return this.hoursOfIdle;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The idle hours should be > 0 at least");
                }
                else this.hoursOfIdle = value;
                
            }
        }

        public byte TalkHours
        {
            get
            {
                return this.hoursOfTalk;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The talk hours should be > 0 at least");
                }
                else this.hoursOfTalk = value;

            }
        }

        // Override method ToString()    
        public override string ToString()   // Problem 5
        {
            return String.Format("Battery Type: {0} \nHours Idle: {1} hours \nHours Talk: {2} hours",
               this.BatteryType, this.IdleHours, this.hoursOfTalk );
        }
    }

    // Create enumaration for baterry types
    public enum BatteryType   // Problem 3
    {
        Li_Poly,
        Li_Ion,
        Li_Po,
        NiCd,
        NiMH,
        Unknown
    }
}
