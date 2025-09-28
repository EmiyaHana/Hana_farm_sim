using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Animal> animals = new List<Animal>();
    
    void Start()
    {
        Chicken Chicken = gameObject.AddComponent<Chicken>();
        Chicken.Init("Cooper", FoodType.Grain);
        
        Cow Cow = gameObject.AddComponent<Cow>();
        Cow.Init("Sebastian", FoodType.Hay);
        
        Pig Pig = gameObject.AddComponent<Pig>();
        Pig.Init("Pete", FoodType.Vegetables);

        animals.Add(Chicken);
        animals.Add(Cow);
        animals.Add(Pig);
        
        Debug.Log("Time for Farming!");
        Debug.Log("There are 3 animals in the farm now.");

        foreach (var animal in animals)
        {
            animal.ShowStat();
        }

        foreach (var animal in animals)
        {
            animal.MakeSound();

            if (animal is Chicken)
                animal.Feed(5);
            else if (animal is Cow)
                animal.Feed(5);
            else if (animal is Pig)
                animal.Feed(5);
        }
        Chicken.Feed(20);
        Chicken.Sleep();
        Chicken.Feed(FoodType.Grain, 30);
        Chicken.Produce();
        Chicken.Feed(FoodType.RottenFood, 30);
        Chicken.Produce();
        Chicken.Feed(FoodType.RottenFood, 30);
        Chicken.Produce();
        Chicken.Feed(FoodType.AnimalFood, 30);
        Chicken.Produce();
        Chicken.ShowStat();

        Cow.Feed(20);
        Cow.Moo();
        Cow.Feed(FoodType.Hay, 30);
        Cow.Produce();
        Cow.Feed(FoodType.RottenFood, 30);
        Cow.Produce();
        Cow.ShowStat();

        Pig.Feed(20);
        Pig.SpecialFood();
        Pig.Feed(FoodType.Vegetables, 30);
        Pig.Produce();
        Pig.Feed(FoodType.RottenFood, 30);
        Pig.Produce();
        Pig.Feed(FoodType.RottenFood, 30);
        Pig.Produce();
        Pig.ShowStat();
    }
}