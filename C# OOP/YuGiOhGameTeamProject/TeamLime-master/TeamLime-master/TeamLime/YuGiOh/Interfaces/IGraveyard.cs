namespace YuGiOh.Interfaces
{
    using YuGiOh.Cards;

    public interface IGraveyard
    {
       void SendCardToGraveyard(Card card);

       void RemoveCardFromGraveyard(Card card);
    }
}
