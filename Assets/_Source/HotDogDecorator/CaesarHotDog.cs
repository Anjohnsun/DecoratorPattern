namespace HotDog
{
    public class CaesarHotDog : HotDog
    {
        //Конструктор
        public CaesarHotDog(SOHotDogData hotDogData) : base(hotDogData)
        {
        }

        public override int GetCost() => HotDogData.cost;

        public override string GetName() => HotDogData.name;

        public override int GetWeight() => HotDogData.weight;
    }

}