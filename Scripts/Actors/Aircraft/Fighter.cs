/*******************************************************************************
* FIGHTER VEHICLE CLASS FILE
*******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Actor
{
    public Fighter(string name) : base(name)
    {
        health = 100;
        movement = 3;
        moveReset = 3;
        minifigureDamage = 75;
        vehicleDamage = 50;
        aircraftDamage = 50;
        range = 2;
        cost = 250;
        type = "Aircraft";
        klass = "Fighter";
        description = "Fighter.";
    }
}
