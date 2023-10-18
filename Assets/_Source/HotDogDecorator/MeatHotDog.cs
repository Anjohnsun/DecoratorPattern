namespace HotDog
{
    public class MeatHotDog : HotDog
    {

        public MeatHotDog(SOHotDogData hotDogData) : base(hotDogData)
        {
        }

        public override int GetCost() => HotDogData.cost;

        public override string GetName() => HotDogData.name;

        public override int GetWeight() => HotDogData.weight;
    }
}