namespace YuGiOh.Engine
{
    using YuGiOh.Extensions;

    public interface IFieldManager
    {
        void Attack(CardId atackingCard, CardId defendingCard);

        void Play(CardId atackingCard); 
     
        void Switch(CardId atackingCard);

    }
}
