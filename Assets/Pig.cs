using System.Collections.Generic;
using UnityEngine;

public class Pig : Animal
{
    public override void Init(string newName, int newHunger, int newHappiness)
    {
        base.Init(newName, newHunger, newHappiness);
    }

    public override void MakeSound()
    {
        Debug.Log("Oink! Oink!");
    }
}