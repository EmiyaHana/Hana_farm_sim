using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>();

    void Start()
    {
        Debug.Log("Time for Farming!");
        Debug.Log("There are 3 animals in the farm now.");

        Chicken Ani1 = gameObject.AddComponent<Chicken>();
        Ani1.Init("Cooper", 25, 10);
        
        Cow Ani2 = gameObject.AddComponent<Cow>();
        Ani2.Init("Sebastian", 25, 10);
        
        Pig Ani3 = gameObject.AddComponent<Pig>();
        Ani3.Init("Pete",25, 10);

        animals.Add(Ani1);
        animals.Add(Ani2);
        animals.Add(Ani3);
        
        foreach (var animal in animals)
        {
            animal.ShowStat();
        }

        foreach (var animal in animals)
        {
            animal.MakeSound();

            if (animal is Chicken)
                animal.Feed("Seed", 5);
            else if (animal is Cow)
                animal.Feed("Wheat", 15);
            else if (animal is Pig)
                animal.Feed("Vegetables", 10);
        }

        Ani1.ShowStat();
        Ani1.Sleep();
        Ani1.ShowStat();

        Ani2.ShowStat();
        Ani2.Moo();
        Ani2.ShowStat();

        Ani3.ShowStat();
        Ani3.MakeSound();
        Ani3.Feed("Fruits", 3);
        Ani3.ShowStat();
    }
}