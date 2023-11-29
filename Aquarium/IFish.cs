namespace Aquarium
{
    interface IFish
    {
        IFish Clone();
        void ShowInfo();
        void ReduceLife();
    }
}