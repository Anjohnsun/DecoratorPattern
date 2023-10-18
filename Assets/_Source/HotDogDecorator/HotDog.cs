namespace HotDog
{
    public abstract class HotDog
    {
        public SOHotDogData HotDogData { get; protected set; }

        //Конструктор
        protected HotDog(SOHotDogData hotDogData)
        {
            HotDogData = hotDogData;
        }

        public abstract string GetName();
        public abstract int GetCost();
        public abstract int GetWeight();

        public override string ToString()
        {
            return $"{GetName()} ({GetWeight()}г) - {GetCost()}";
        }
    }
}