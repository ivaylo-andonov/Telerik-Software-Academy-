namespace Cooking
{
    using Ingredients;
    using Utensils;

    public class Cheff
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);
        }
        
        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Cut(IVegetable potato)
        {
        }

        private void Peel(IVegetable vegetable)
        {
        }
    }
}
