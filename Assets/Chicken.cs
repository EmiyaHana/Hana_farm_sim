using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal
{
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

    public override void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
        Eggs = 0;
    }

    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"Eggs : {Eggs}");
    }

    public override void MakeSound()
    {
        Debug.Log("Cluck! Cluck!");
    }

    public void Sleep()
    {
        Debug.Log($"{Name} is Sleeping now! {Name} feels a bit hungry but still happy!");

        IsFeeded = false;
        IsSleep = true;

        AdjustHunger();
        AdjustHappiness();
    }
}