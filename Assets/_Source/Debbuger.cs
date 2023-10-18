using UnityEngine;
using HotDog;

public class Debbuger : MonoBehaviour
{
    [SerializeField] private SOHotDogData _hotdogData;
    [SerializeField] private SOHotDogData _cucumberHotdogData;
    [SerializeField] private SOHotDogData _onionHotDogData;

    void Start()
    {
        ClassicHotDog classicHotDog = new ClassicHotDog(_hotdogData);
        DecoratedClassicHotDog classicHotDogWithCucumber = new DecoratedClassicHotDog(_cucumberHotdogData, classicHotDog);
        DecoratedClassicHotDog classicHotDogWithOnion = new DecoratedClassicHotDog(_onionHotDogData, classicHotDog);

        Debug.Log(classicHotDog.ToString());
        Debug.Log(classicHotDogWithCucumber.ToString());
        Debug.Log(classicHotDogWithOnion.ToString());
    }
}
