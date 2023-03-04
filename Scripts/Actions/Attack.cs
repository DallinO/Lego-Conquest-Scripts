using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*******************************************************************************
* ATTACK HEADER FILE
*******************************************************************************/
class Attack : CheckNSelect {
    private int targetPlayer;
    private int attackingUnit;
    private int targetUnit;

    /***************************************
    * APPLY DAMAGE
    ***************************************/
    public void ApplyDamage(int player, List<Player> players)
    {
        if (players[targetPlayer].GetArmy()[targetUnit].GetTypeAtt() == "Minifigure") {
            players[targetPlayer].GetArmy()[targetUnit].ApplyDamage(players[player].GetArmy()[attackingUnit].GetMinifigureDamage());
        }
        else if (players[targetPlayer].GetArmy()[targetUnit].GetTypeAtt() == "Vehicle") {
            players[targetPlayer].GetArmy()[targetUnit].ApplyDamage(players[player].GetArmy()[attackingUnit].GetVehicleDamage());
        }
        else if (players[targetPlayer].GetArmy()[targetUnit].GetTypeAtt() == "Aircraft") {
            players[targetPlayer].GetArmy()[targetUnit].ApplyDamage(players[player].GetArmy()[attackingUnit].GetAircraftDamage());
        }

        // Check if the target was killed
        if (players[targetPlayer].GetArmy()[targetUnit].GetIsDead())
        {
            // Remove the killed unit from the target players army
            players[targetPlayer].GetArmy().RemoveAt(targetUnit);
        }

        Console.Clear();
        Console.WriteLine(players[player].GetArmy()[attackingUnit].GetName() + " attacked " + players[targetPlayer].GetArmy()[targetUnit].GetName());
        System.Threading.Thread.Sleep(2000);
    }

    /***************************************
    * ACTION
    * Summary:
    *   Facilitates all actions necessary
    *   to performing the attack procedure
    ***************************************/
    public void Action(int player, ref List<Player> players, int numplayers)
    {
        // Check if the attacking player has any units
        if (CheckUnits(players, player))
        {
            // Select attacking unit
            Console.WriteLine("Select attacking unit: ");
            attackingUnit = SelectUnit(players, player);

            // If there are more than 2 players then select
            // the player to attack
            if (numplayers > 2)
            {
                Console.WriteLine("Enter the player to attack: ");
                targetPlayer = int.Parse(Console.ReadLine());
                if (CheckUnits(players, targetPlayer))
                {
                    // Select target unit
                    Console.WriteLine("Select unit to attack: ");
                    targetUnit = SelectUnit(players, targetPlayer);
                    ApplyDamage(player, players);
                }
            }
            // If there are only two players than the target
            // player is automatically selected
            else
            {
                if (player == 0)
                    targetPlayer = 1;
                else
                    targetPlayer = 0;
                if (CheckUnits(players, targetPlayer))
                {
                    // Select target unit
                    Console.WriteLine("Select unit to attack: ");
                    targetUnit = SelectUnit(players, targetPlayer);
                    ApplyDamage(player, players);
                }
            }
        }
    }
}

