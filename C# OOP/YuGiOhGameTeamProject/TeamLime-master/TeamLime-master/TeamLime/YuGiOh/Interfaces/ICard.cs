namespace YuGiOh.Interfaces
{
    public interface ICard
    {

        string InfoText { get; set; }

        string PathToImage { get; set; }

        void SwitchPosition();
    }
}