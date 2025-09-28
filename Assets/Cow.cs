using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal
{
    public float Milk { get; private set; }

    public override void Init(string newName, int newHunger, int newHappiness, FoodType preferedFood)
    {
        base.Init(newName, newHunger, newHappiness, FoodType.Hay);
        Milk = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Milk : {Milk}");
    }

    public override void Produce()
    {   
        int Produced = 0;
        if (Happiness >= 70)
        {
            Produced = Happiness/10;
        }
        else
        {
            Produced = 0;
        }

        Milk += Produced;
        Debug.Log($"{Name} produces {Produced} units of milk.");
        Debug.Log($"Milk : {Milk} units");
    }

    public override void MakeSound()
    {
        Debug.Log("Moo! Moo!");
    }

    public void Moo()
    {
        AdjustHappiness(10);

        Debug.Log($"Moo! Moo! Moo! {Name} is mooing loudly and very happy now!");
        Debug.Log($"Hunger : {Hunger} | Happiness : {Happiness}");
    }
}