namespace YuGiOh.Extensions
{
    using System;

    public static class RandomProvider
    {
        private static Random instance;

        public static Random Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Random();
                }

                return instance;
            }
        }
    }
}
