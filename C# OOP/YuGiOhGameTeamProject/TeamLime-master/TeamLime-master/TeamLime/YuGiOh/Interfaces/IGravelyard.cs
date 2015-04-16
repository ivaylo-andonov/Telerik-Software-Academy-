namespace YuGiOh.Interfaces
{
    using YuGiOh.Cards;

    public interface IGravelyard
    {
       void SendCardToGraveyard(Card card);

       void RemoveCardFromGraveyard(Card card);
    }
}
