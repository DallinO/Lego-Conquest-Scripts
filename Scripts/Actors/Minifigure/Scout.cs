/*******************************************************************************
* SCOUT HEADER FILE
*******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scout : Actor
{
    public Scout(string name) : base(name)
    {
        health = 75;
        movement = 1;
        moveReset = 1;
        minifigureDamage = 150;
        vehicleDamage = 0;
        aircraftDamage = 0;
        range = 3;
        cost = 300;
        type = "Minifigure";
        klass = "Scout";
        description = "Scout";
    }
}