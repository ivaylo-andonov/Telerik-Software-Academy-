namespace YuGiOh.Cards
{
    using YuGiOh.Players;
    using YuGiOh.Interfaces;

    public  abstract class Spell : Card,ISpell
    {
        private SpellTypes spellType;

        public Spell(SpellTypes spellType, string infoText, string pathToImage)
            : base(infoText, pathToImage)
        {
            this.SpellType = spellType;
        }

        public SpellTypes SpellType
        {
            get
            {
                return this.spellType;
            }
            set
            {
                this.spellType = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("| Effect: {0} |", this.InfoText);
        }
    }
}