namespace YuGiOh.Players
{
    using YuGiOh.Interfaces;

    public interface IPlayer
    {
        string Name { get; set; }

        IDeck PlayerDeck { get; set; }

        void DrawNextCardInHand();

        void SendCardToField(ICard choosenCard);

        void VisionCardInHand();

        void DrawPlayCardsFromYuGiOhDeck(int numberOfPlayableCards);
    }
}
