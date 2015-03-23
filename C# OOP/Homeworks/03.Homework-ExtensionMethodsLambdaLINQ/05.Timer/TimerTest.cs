namespace Timer
{
    using System;
    using System.Threading.Tasks;
    using System.Timers;

    public delegate void Message(int sec);

    class TimerTest
    {
        static void PrintOddMessage(int sec)
        {
            Console.WriteLine("- Seconds are odd");
        }
        static void PrintEvenMessage(int sec)
        {
            Console.WriteLine("- Seconds are even");
        }
        static void TimerElasped(object soruce, ElapsedEventArgs myEvent)
        {
            Console.Write("Method is raised at {0} ", myEvent.SignalTime);
            Message msg = new Message(PrintEvenMessage);
            if (myEvent.SignalTime.Second % 2 != 0)
                msg = PrintOddMessage;
            msg(myEvent.SignalTime.Second);
        }

        static void Main(string[] args)
        {
            Timer timer = new Timer();
            Console.Write("Enter period of seconds to raise event: ");
            int period = int.Parse(Console.ReadLine());
            timer = new Timer(period * 1000);
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(TimerElasped);
            Console.WriteLine("Press ENTER key to exit (not immediately, program is running in background )");
            Console.ReadLine();
        }
    }
}