namespace HotDog
{
    public abstract class HotDogDecorator : HotDog
    {
        protected HotDog hotDog;

        public HotDogDecorator(SOHotDogData hotDogData, HotDog hotDog) : base(hotDogData)
        {
            this.hotDog = hotDog;
        }
    }
}