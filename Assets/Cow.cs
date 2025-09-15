using System.Collections.Generic;
using UnityEngine;

public class Cow
{
    private string name;
    public string Name
    {
        get { return name; }
        set 
        { if (string.IsNullOrEmpty(value)) { name = "Cow"; }
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
    public bool IsMoo = false;

    public int Fullfil;
    public int Hungry;
    public int Happy;

    private float milk;
    public float Milk
    { 
        get { return milk; }
        set 
        {
            if (value >= 0) milk = value;
            else milk = 0;
        }
    }

    public Cow(string newName, int newHunger, int newHappiness, float NewMilk)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        Milk = 0;
    }

    public void ShowStat()
    {
        Debug.Log($"Cow : {Name} | Hunger : {Hunger} | Happiness : {Happiness} | Milk : {Milk}");
    }

    public void MakeSound()
    {
        Debug.Log("Moo! Moo!");
    }

    public void Feed(string Wheat)
    {
        Debug.Log($"C'mon {Name}! Here's your {Wheat}.");
        Debug.Log($"{Name} eat {Wheat} Happily!");

        IsFeeded = true;
        IsMoo = false;

        AdjustHunger(Fullfil, Hungry);
        AdjustHappiness(Happy);
    }

    public void Moo()
    {
        Debug.Log($"Moo! Moo! Moo! {Name} is mooing loudly and very happy now!");

        IsFeeded = false;
        IsMoo = true;

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
           Hungry = 0;
           Hunger += Hungry;
        }
    }

    public void AdjustHappiness(int Happy)
    {
        if (IsMoo)
        {
           Happy = 10;
           Happiness += Happy;
        }
        else if (!IsMoo)
        {
           Happy = 5;
           Happiness += Happy;
        }
    }
}