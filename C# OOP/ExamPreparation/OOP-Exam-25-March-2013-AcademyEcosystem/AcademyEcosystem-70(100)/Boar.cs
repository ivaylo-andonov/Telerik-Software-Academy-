namespace AcademyEcosystem
{
    using System;

    public class Boar: Animal,IHerbivore,ICarnivore
    {
        private int biteSize;

        public Boar(string name, Point location)
            : base(name, location, 4)
        {
            this.biteSize = 2;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                
                this.Size += 1;
                return plant.GetEatenQuantity(this.biteSize);
                            
            }
            return 0;
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }
            return 0;
        }
    }
}
