using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private List<Actor> army;
    private int number;
    private string name;
    private int credits;
    private int health;

    public Player(int number, string name)
    {
        this.number = number;
        this.name = name;
        health = 4000;
        credits = 0;
        army = new List<Actor>();
    }

    public void AddCredits(int credits)
    {
        this.credits += credits;
    }

    public void RemoveCredits(int credits)
    {
        this.credits -= credits;
    }

    public int GetCredits()
    {
        return credits;
    }

    public int GetNumber()
    {
        return number;
    }

    public int GetHealth()
    {
        return health;
    }

    public string GetName()
    {
        return name;
    }

    public int GetArmySize()
    {
        return army.Count;
    }

    public List<Actor> GetArmy()
    {
        return army;
    }

    public void AddUnit(List<string> unit, int klass, int name)
    {
        if (klass == 1)
        {
            Assault assault = new Assault(unit[name]);
            army.Add(assault);
        }
        else if (klass == 2)
        {
            Heavy heavy = new Heavy(unit[name]);
            army.Add(heavy);
        }
        else if (klass == 3)
        {
            Scout scout = new Scout(unit[name]);
            army.Add(scout);
        }
        else if (klass == 4)
        {
            Officer officer = new Officer(unit[name]);
            army.Add(officer);
        }
    }
}

