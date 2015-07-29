namespace Abstraction
{
    using System.Text;

    internal abstract class Figure
    {
        internal Figure()
        {
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("I am a " + this.GetType().Name);
            result.AppendFormat("My perimeter is {0:f2}", this.CalcPerimeter());
            result.AppendLine();
            result.AppendFormat("My surface is {0:f2}.", this.CalcSurface());

            return result.ToString();
        }

        internal abstract double CalcPerimeter();

        internal abstract double CalcSurface();
    }
}