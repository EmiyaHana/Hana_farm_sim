using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
    public int Eggs { get; private set; }
    
    public override void Init(string newName, int newHunger, int newHappiness, FoodType preferedFood)
    {
        base.Init(newName, newHunger, newHappiness, FoodType.Grain);
        Eggs = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Eggs : {Eggs}");
    }

    public override void Produce()
    {
        int Produced = 0;
        if (Happiness >= 51 && Happiness <= 79)
        {
            Produced = 2;
        }
        else if (Happiness >= 80)
        {
            Produced = 3;
        }
        
        Eggs += Produced;
        Debug.Log($"{Name} produces {Produced} units of eggs.");
        Debug.Log($"Eggs : {Eggs} units");
    }

    public override void MakeSound()
    {
        Debug.Log("Cluck! Cluck!");
    }

    public void Sleep()
    {
        AdjustHunger(5);
        AdjustHappiness(10);

        Debug.Log($"{Name} is Sleeping now! {Name} feels a bit hungry but still happy!");
        Debug.Log($"Hunger : {Hunger} | Happiness : {Happiness}");
    }
}