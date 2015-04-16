namespace YuGiOh.Extensions
{
    using System;

    using System.Threading;

    using System.Globalization;

    using YuGiOh.Extensions.Helper;

    public class ExtendedGameExeption : ApplicationException
    {
        public ExtendedGameExeption(string message)
            : base(message)
        {

        }
        // call / implement OnProblem
    }

    public class Observable
    {
        //observable -/-observed
        public event EventHandler GeneralProblem;

        protected virtual void OnGeneralProblem(EventArgs args)
        {
            EventHandler handler = GeneralProblem;
            if (handler != null)
            {
                handler(this, args);
            }
        }
    }

    public class Observer
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine("There was a problem! " + "Something happened to " + sender);

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Constants.EventErrorSound(Constants.PlaySound);
        }
    }

    class OnProblem
    {
        static void Problem()
        {
            Observable observable = new Observable();
            Observer observer = new Observer();
            observable.GeneralProblem += observer.HandleEvent;
        }
    }
}
