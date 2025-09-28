using System.Collections.Generic;
using UnityEngine;

public class Pig : Animal
{
    public int Pork { get; private set; }
 
    public override void Init(string newName, FoodType preferedFood)
    {
        base.Init(newName, FoodType.Vegetables);
        Pork = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Pork : {Pork}");
    }

    public override void Produce()
    {
        int Produced = 0;
        if (Happiness >= 70)
        {
            Produced = Happiness/5;
        }
        else
        {
            Produced = 0;
        }

        Pork += Produced;
        Debug.Log($"{Name} produces {Produced} units of pork.");
        Debug.Log($"Pork : {Pork} units");
    }

    public override void MakeSound()
    {
        Debug.Log("Oink! Oink!");
    }

    public void SpecialFood()
    {
        AdjustHunger(-15);
        AdjustHappiness(20);

        Debug.Log($"{Name} is eating {FoodType.Fruits}! {Name} feels very happy!");
        Debug.Log($"Hunger : {Hunger} | Happiness : {Happiness}");
    }
}