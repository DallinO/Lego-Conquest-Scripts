/*******************************************************************************
* ASSAULT Class FILE
*******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Assault : Actor
{
    public Assault(string name) : base(name)
    {
        health = 100;
        movement = 2;
        moveReset = 2;
        minifigureDamage = 50;
        vehicleDamage = 10;
        aircraftDamage = 0;
        range = 2;
        cost = 75;
        type = "Minifigure";
        klass = "Assualt";
        description = "Your basic grunt.";
    }
}

