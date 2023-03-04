/*******************************************************************************
* ARMOUR VEHICLE CLASS FILE
*******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Armour : Actor
{
    public Armour(string name) : base(name)
    {
        health = 150;
        movement = 2;
        moveReset = 2;
        minifigureDamage = 100;
        vehicleDamage = 75;
        aircraftDamage = 50;
        range = 2;
        cost = 250;
        type = "Vehicle";
        klass = "Armour";
        description = "Well rounded assault vehicle.";
    }
}
