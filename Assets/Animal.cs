using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    private string name;
    public string Name
    {
        get { return name; }
        set 
        { if (string.IsNullOrEmpty(value)) { name = "Unknown"; }
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
    public bool IsMoo = false;

    public virtual void Init(string newName, int newHunger, int newHappiness)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
    }

    public virtual void ShowStat()
    {
        Debug.Log($"Name : {Name} | Hunger : {Hunger} | Happiness : {Happiness}");
    }

    public virtual void MakeSound()
    {
        /*Debug.Log("There's a sound louding...'");*/
    }

    public void Feed(string Feed)
    {
        Debug.Log($"C'mon {Name}! Here's your {Feed}.");
        Debug.Log($"{Name} eat {Feed} Happily!");

        IsFeeded = true;
        IsSleep = false;

        AdjustHunger();
        AdjustHappiness();
    }

    public void Feed(string Feed, int amount)
    {
        Debug.Log($"C'mon {Name}! Here's your {Feed}.");
        Debug.Log($"{Name} eat {Feed} Happily!");
        Debug.Log($"Feeding {Name} with {amount} of {Feed}!");

        IsFeeded = true;
        IsSleep = false;

        AdjustHunger();
        AdjustHappiness();
    }

    public void AdjustHunger()
    {
        if (IsFeeded)
        {
           Hunger -= 10;
        }
        else
        {
           Hunger += 5;
        }
    }

    public void AdjustHappiness()
    {
        if (IsSleep)
        {
           Happiness += 10;
        }
        else
        {
           Happiness += 5;
        }
    }
}
