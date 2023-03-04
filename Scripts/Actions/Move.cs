using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*******************************************************************************
* MOVE HEADER FILE
*******************************************************************************/
class Move : CheckNSelect {
    private int unit;
    private int spaces;

    public void ResetMoves(int player, ref List<Player> players) {
        foreach (Actor unit in players[player].GetArmy()) {
            unit.ResetMovement();
        }
    }

    public void Action(int player, ref List<Player> players) {
        if (CheckUnits(players, player)) {
            // Select unit
            Console.WriteLine("Select unit to move:");
            unit = SelectUnit(players, player);
            Console.WriteLine("Spaces:");
            while (true) {
                Console.Write(">>> ");
                spaces = Convert.ToInt32(Console.ReadLine());
                if (spaces > players[player].GetArmy()[unit].GetMovement()) {
                    Console.WriteLine("Not enough movements available!");
                } else {
                    players[player].GetArmy()[unit].MoveActor(spaces);
                    break;
                }
            }
        }
    }
}
