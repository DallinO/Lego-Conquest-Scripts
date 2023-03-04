/*******************************************************************************
* CHECKNSELECT CLASS FILE
*******************************************************************************/
using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckNSelect : MonoBehaviour
{

    /***************************************
    * CHECK UNITS
    ***************************************/
    public bool CheckUnits(List<Player> players, int player)
    {
        if (players[player].GetArmySize() == 0)
        {
            Console.Clear();
            Console.WriteLine("No units available!");
            Thread.Sleep(2000);
            return false;
        }
        else
            return true;
    }

    /***************************************
    * SELECT UNIT
    ***************************************/
    public int SelectUnit(List<Player> players, int player)
    {
        string unit;
        int u = 1;
        foreach (Actor actor in players[player].GetArmy())
        {
            Console.WriteLine(u + ") " + actor.GetName());
            u++;
        }
        while (true)
        {
            unit = Console.ReadLine();
            u = int.Parse(unit);
            if (u > players[player].GetArmySize() || u < 1)
                Console.WriteLine("Out of option range!");
            else
                return int.Parse(unit) - 1;
        }
    }
}