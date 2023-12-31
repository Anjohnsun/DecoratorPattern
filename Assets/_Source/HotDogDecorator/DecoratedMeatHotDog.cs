﻿namespace HotDog
{
    class DecoratedMeatHotDog : HotDogDecorator
    {
        protected Ingredient ingredient;

        public DecoratedMeatHotDog(SOHotDogData hotDogData, HotDog hotDog) : base(hotDogData, hotDog)
        {
            ingredient = hotDogData.extraIngredient;
        }

        public override int GetCost() => hotDog.GetCost() + ingredient.cost;

        public override int GetWeight() => hotDog.GetWeight() + ingredient.weight;


        public override string GetName() => hotDog.GetName() + " c " + ingredient;
    }
}