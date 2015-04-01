namespace AcademyEcosystem
{
    using System;

    public class Grass:Plant
    {
        public Grass(Point location)
            : base(location, 2)
        {       
        }

        public override void Update(int time)
        {
            if (this.IsAlive)
            {
                this.Size += time;
            }
            base.Update(time);
        }
    }    
}
