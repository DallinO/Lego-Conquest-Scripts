/*******************************************************************************
* ARTILLARY VEHICLE HEADER FILE
*******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Artillery : Actor
{
    public Artillery(string name) : base(name) {
        health = 225;
        movement = 1;
        moveReset = 1;
        minifigureDamage = 100;
        vehicleDamage = 75;
        aircraftDamage = 0;
        range = 3;
        cost = 550;
        type = "Vehicle";
        klass = "Artillary";
        description = "Deals damage to all entities on a single tile.\nCan not target tiles immediatly adjacent.";
    }
}
