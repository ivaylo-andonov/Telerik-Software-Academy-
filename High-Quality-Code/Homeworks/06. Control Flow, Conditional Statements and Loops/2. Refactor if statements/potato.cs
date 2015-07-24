namespace RefactorIf
{
    internal class Potato
    {
        public bool IsPeeled { get; set; }

        public bool IsRotten { get; set; }

        internal void Cook()
        {
            System.Console.WriteLine("Potato is being cooked!");
        }
    }
}
