namespace RefactorIf
{
    using System;

    public static class EntryPoint
    {
        private const int MinX = 0;
        private const int MaxX = 10;
        private const int MinY = 0;
        private const int MaxY = 10;

        public static void Main()
        {
            Potato myPotato = new Potato();

            // ... 
            if (myPotato != null && myPotato.IsPeeled && !myPotato.IsRotten)
            {
                myPotato.Cook();
            }

            int x = 5;
            int y = 15;
            bool shouldVisitCell = true;

            bool xIsInRange = MinX <= x && x <= MaxX;
            bool yIsInRange = MinY <= y && y <= MaxY;
            if (xIsInRange && yIsInRange && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("Cell was visited!");
        }
    }
}
