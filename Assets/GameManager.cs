using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Time for Farming!");

        Chicken chicken = new Chicken("Cooper",25 ,10 ,0);
        Cow cow = new Cow("Sebastian",25 ,10 ,0);

        Debug.Log($"{chicken.Name} and {cow.Name} are in the farm now.");

        chicken.ShowStat();
        chicken.MakeSound();
        chicken.Feed("Seed");
        chicken.ShowStat();
        chicken.Sleep();
        chicken.ShowStat();

        cow.ShowStat();
        cow.MakeSound();
        cow.Feed("Wheat");
        cow.ShowStat();
        cow.Moo();
        cow.ShowStat();
    }
}