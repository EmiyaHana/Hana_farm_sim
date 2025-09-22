using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal
{
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

    public override void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
        Milk = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Milk : {Milk}");
    }

    public override void MakeSound()
    {
        Debug.Log("Moo! Moo!");
    }

    public void Moo()
    {
        Debug.Log($"Moo! Moo! Moo! {Name} is mooing loudly and very happy now!");

        IsFeeded = false;
        IsMoo = true;

        AdjustHunger();
        AdjustHappiness();
    }
}