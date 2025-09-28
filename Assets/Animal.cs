using UnityEngine;

public enum FoodType
{
    Hay,
    Grain,
    Vegetables,
    Fruits,
    RottenFood,
    AnimalFood
}

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

    public int Hunger { get; protected set; }
    protected int maxHunger = 100;

    public int Happiness { get; protected set; }
    protected int maxHappiness = 100;

    public FoodType PreferedFood { get; private set; }

    public virtual void Init(string newName, int newHunger, int newHappiness, FoodType preferedFood)
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappiness;
        PreferedFood = preferedFood;
    }

    public virtual void ShowStat()
    {
        Debug.Log($"Name : {Name} | Hunger : {Hunger} | Happiness : {Happiness}");
    }

    public abstract void MakeSound();

    public abstract void Produce();

    public void Feed(int amount)
    {
        AdjustHunger(-amount);
        AdjustHappiness(amount/2);

        Debug.Log($"{Name} was fed {amount} units of food.");
        Debug.Log($"Hunger : {Hunger} | Happiness : {Happiness}");
    }

    public void Feed(FoodType Food, int amount)
    {
        if (Food == PreferedFood)
        {
            AdjustHunger(-amount);
            AdjustHappiness(15);

            Debug.Log($"C'mon {Name}! Here's your {Food}.");
            Debug.Log($"{Name} eat {Food} Happily!");
            Debug.Log($"Feeding {Name} with {amount} of {Food}!");
            Debug.Log($"Hunger : {Hunger} | Happiness : {Happiness}");
        }
        else if (Food == FoodType.RottenFood)
        {
            AdjustHunger(0);
            AdjustHappiness(-20);

            Debug.Log($"Eww!?");
            Debug.Log($"{Name} eat rotten food! It's not Happy at all!'");
            Debug.Log($"Feeding {Name} with {amount} of rotten food!");
            Debug.Log($"Hunger : {Hunger} | Happiness : {Happiness}");
        }
        else if (Food == FoodType.AnimalFood)
        {
            Feed(amount);
        }
        else
        {
            Feed(amount);
        }
    }

    public void AdjustHunger(int value)
    {
        Hunger = Mathf.Clamp(Hunger + value, 0, maxHunger);
    }

    public void AdjustHappiness(int value)
    {
        Happiness = Mathf.Clamp(Happiness + value, 0, maxHappiness);
    }
}