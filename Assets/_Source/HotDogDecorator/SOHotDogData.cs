using UnityEngine;
using System;

namespace HotDog
{
    [CreateAssetMenu(fileName = "HotDogData", menuName = "HotDogs/NewHotDogData")]
    public class SOHotDogData : ScriptableObject
    {
        public string name;
        public int cost;
        public int weight;
        public Ingredient extraIngredient;
    }

    [Serializable]
    public class Ingredient
    {
        public string name;
        public int cost;
        public int weight;
    }
}