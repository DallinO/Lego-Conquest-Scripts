using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor
{
    protected string name;
    protected string type;
    protected string klass;
    protected string description;
    protected int health;
    protected int movement;
    protected int moveReset;
    protected int range;
    protected bool isDead;
    protected int cost;

    protected int minifigureDamage;
    protected int vehicleDamage;
    protected int aircraftDamage;

    public Actor(string name) { 
        this.name = name; 
        isDead = false; 
    }

    public void ApplyDamage(int damage) {   
        health -= damage; 
        if (health <= 0)
            isDead = true; 
    }

    public void MoveActor(int spaces) { movement -= spaces; }

    public void ResetMovement() { movement = moveReset; }

    public string GetName() { return name; }

    public string GetClass() { return klass; }

    public string GetTypeAtt() { return type; }

    public int GetHealth() { return health; }

    public int GetMovement() { return movement; }

    public int GetRange() { return range; }

    public int GetMinifigureDamage() { return minifigureDamage; }

    public int GetVehicleDamage() { return vehicleDamage; }

    public int GetAircraftDamage() { return aircraftDamage; }

    public string GetDescription() { return description; }

    public bool GetIsDead() { return isDead; }
}


