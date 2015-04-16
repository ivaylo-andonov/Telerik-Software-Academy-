namespace YuGiOh.Interfaces
{
    using YuGiOh.Cards;
    using System.Collections.Generic;

    public interface IDeck
    {
        ICard DrawNextCard();

        IList<ICard> InitializeYuGiOhCards();

        int CardsLeft { get; }
    }
}
