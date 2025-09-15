using System.Collections.Generic;
using UnityEngine;

public class Chicken
{
    private string name;
    public string Name
    {
        get { return name; }
        set 
        { if (string.IsNullOrEmpty(value)) { name = "Chicken"; }
          else { name = value; }
        }
    }

    private int hunger;
    public int Hunger 
    {
        get { return hunger; }
        set 
        { 
            if (value > 50) { hunger = 50; }
            else if (value <= 0) { hunger = 0; }
            else { hunger = value; }
        }
    }

    private int happiness;
    public int Happiness
    { 
        get { return happiness; }
        set 
        {
            if (value > 50) { happiness = 50; }
            else if (value <= 0) { happiness = 0; }
            else { happiness = value; }
        }
    }

    public bool IsFeeded = false;
    public bool IsSleep = false;

    public int Fullfil;
    public int Hungry;
    public int Happy;

    private int eggs;
    public int Eggs
    { 
        get { return eggs; }
        set 
        {
            if (value >= 0) eggs = value;
            else eggs = 0;
        }
    }

    public Chicken(string newName, int newHunger, int newHappiness, int NewEggs)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Eggs = 0;
    }

    public void ShowStat()
    {
        Debug.Log($"Chicken : {Name} | Hunger : {Hunger} | Happiness : {Happiness} | Eggs : {Eggs}");
    }

    public void MakeSound()
    {
        Debug.Log("Cluck! Cluck!");
    }

    public void Feed(string Seed)
    {
        Debug.Log($"C'mon {Name}! Here's your {Seed}.");
        Debug.Log($"{Name} eat {Seed} Happily!");

        IsFeeded = true;
        IsSleep = false;

        AdjustHunger(Fullfil, Hungry);
        AdjustHappiness(Happy);
    }

    public void Sleep()
    {
        Debug.Log($"{Name} is Sleeping now! {Name} feels a bit hungry but still happy!");

        IsFeeded = false;
        IsSleep = true;

        AdjustHunger(Fullfil, Hungry);
        AdjustHappiness(Happy);
    }

    public void AdjustHunger(int Fullfil, int Hungry)
    {
        if (IsFeeded)
        {
           Fullfil = 10;
           Hunger -= Fullfil;
        }
        else if (!IsFeeded)
        {
           Hungry = 5;
           Hunger += Hungry;
        }
    }

    public void AdjustHappiness(int Happy)
    {
        if (IsSleep)
        {
           Happy = 10;
           Happiness += Happy;
        }
        else if (!IsSleep)
        {
           Happy = 5;
           Happiness += Happy;
        }
    }
}