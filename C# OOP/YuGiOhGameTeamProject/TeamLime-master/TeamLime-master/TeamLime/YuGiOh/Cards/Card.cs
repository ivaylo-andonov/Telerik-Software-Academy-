namespace YuGiOh.Cards
{
    using System;
    using YuGiOh.Interfaces;

    public abstract class Card : ICard
    {
        private string infoText;
        private string pathToImage;
        public bool isInDefense;

        public Card(string infoText, string pathToImage)
        {
            this.InfoText = infoText;
            this.PathToImage = pathToImage;
            this.isInDefense = false;
        }
        public string InfoText
        {
            get
            {
                return this.infoText;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The card must have info text");
                }

                this.infoText = value;
            }
        }

        public string PathToImage
        {
            get
            {
                return this.pathToImage;
            }
            set
            {
                this.pathToImage = value;
            }
        }

        public virtual void SwitchPosition()
        {
            this.isInDefense = !this.isInDefense;
        }

        public override string ToString()
        {
            return string.Format("Card Name: {0} | Card Type: {1}",
                this.GetType().Name,this.GetType().BaseType.Name);
        }
    }
}