/*******************************************************************************
* HEAVY CLASS FILE
*******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heavy : Actor
{
    public Heavy(string name) : base(name)
    {
        health = 115;
        movement = 2;
        moveReset = 2;
        minifigureDamage = 75;
        vehicleDamage = 25;
        aircraftDamage = 0;
        range = 1;
        cost = 150;
        type = "Minifigure";
        klass = "Heavy";
        description = "";
    }
}