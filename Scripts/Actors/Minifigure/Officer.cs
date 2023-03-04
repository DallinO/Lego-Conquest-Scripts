/*******************************************************************************
* OFFICER CLASS
*******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Officer : Actor
{
    public Officer(string name) : base(name)
    {
        health = 200;
        movement = 2;
        moveReset = 2;
        minifigureDamage = 150;
        vehicleDamage = 50;
        aircraftDamage = 0;
        range = 2;
        cost = 500;
        type = "Minifigure";
        klass = "Officer";
        description = "It must be desperate times if officers are fighting.";
    }
}
