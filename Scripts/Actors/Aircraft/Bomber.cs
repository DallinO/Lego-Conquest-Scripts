/*******************************************************************************
* BOMBER VEHICLE CLASS FILE
*******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomber : Actor
{
    public Bomber(string name) : base(name) {
        health = 250;
        movement = 1;
        moveReset = 1;
        minifigureDamage = 100;
        vehicleDamage = 100;
        aircraftDamage = 0;
        range = 1;
        cost = 600;
        type = "Aircraft";
        klass = "Bomber";
        description = "Bomber\nCan target the tile it is over.\nDeals damage to all entities on the tile.";
    }
}
