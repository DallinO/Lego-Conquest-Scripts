using System;
using System.Threading;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy
{
    private readonly List<int> minifigureCost = new List<int> { 75, 150, 300, 500 };
    private readonly List<int> vehicleCost = new List<int> { 250, 550 };
    private readonly List<int> aircraftCost = new List<int> { 250, 600 };
    private readonly List<string> minifigures = new List<string>();
    private readonly List<string> vehicles = new List<string>();
    private readonly List<string> aircraft = new List<string>();

    public Buy()
    {
        using (var file = new StreamReader("minifigures.txt"))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                minifigures.Add(line);
            }
        }
        using (var file = new StreamReader("vehicles.txt"))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                vehicles.Add(line);
            }
        }
        using (var file = new StreamReader("aircraft.txt"))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                aircraft.Add(line);
            }
        }
    }

    private bool CheckFunds(int player, List<Player> players, int klassCost)
    {
        if (players[player].GetCredits() < klassCost)
        {
            Console.WriteLine("\nNot enough credits!\n\n");
            System.Threading.Thread.Sleep(2000);
            return false;
        }
        else
            return true;
    }

    private void GetInput(out string str, out int i, int max)
    {
        while (true)
        {
            Console.Write(">>> ");
            str = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(str, out i))
            {
                if (i < 0 || i > max)
                    Console.WriteLine("Out of option range!\n");
                else
                    break;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter an integer.\n");
            }
        }
    }

    public void Action(int player, ref List<Player> players)
    {
        string type;
        int t;
        string klass;
        int k;
        string num;
        int n;

        Console.Clear();
        Console.WriteLine("-----BUY-----\n");
        Console.Write("TYPE:\n");
        Console.WriteLine("1) Minifigure\n" +
                          "2) Vehicle\n" +
                          "3) Aircraft\n");
        GetInput(out type, out t, 3);

        /* MINIFIGURE */
        if (t == 1)
        {
            int i = 1;
            foreach (string unit in minifigures)
            {
                Console.Write($"{i}) {unit}");
                if (i % 3 == 0)
                    Console.WriteLine();
                Thread.Sleep(10);
                i++;
            }
            Console.WriteLine("\n\nSelect minifiure: ");
            GetInput(out num, out n, minifigures.Count);

            Console.WriteLine($"CLASS:\n" +
                $"1) Assualt\t75 CR\n" +
                $"2) Heavy\t150 CR\n" +
                $"3) Scout\t300 CR\n" +
                $"4) Officer\t500 CR\n");
            GetInput(out klass, out k, 4);

            if (CheckFunds(player, players, minifigureCost[k - 1]))
            {
                players[player].AddUnit(minifigures, k, n - 1);
                players[player].RemoveCredits(minifigureCost[k - 1]);
            }
        }

        /*** VEHICLE ***/
        if (t == 2)
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine($"{i}) {vehicles[i]}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Select Vehicle: ");
            GetInput(out num, out n, vehicles.Count);
            Console.WriteLine($"CLASS:\n" +
                $"1) Armour\t250 CR\n" +
                $"2) Artillary\t550 CR\n");
            GetInput(out klass, out k, 2);
            if (CheckFunds(player, players, vehicleCost[k - 1]))
            {
                players[player].AddUnit(vehicles, k, n - 1);
                players[player].RemoveCredits(minifigureCost[k - 1]);
            }
        }

        /*** AIRCRAFT ***/
        if (t == 3)
        {
            for (int i = 0; i < aircraft.Count; i++)
            {
                Console.WriteLine($"{i}) {aircraft[i]}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Select Aircraft: ");
            GetInput(out num, out n, aircraft.Count);
            Console.WriteLine($"CLASS:\n" +
                $"1) Fighter\t250 CR\n" +
                $"2) Bomber\t600 CR\n");
            GetInput(out klass, out k, 2);
            if (CheckFunds(player, players, aircraftCost[k - 1]))
            {
                players[player].AddUnit(aircraft, k, n - 1);
                players[player].RemoveCredits(minifigureCost[k - 1]);
            }
        }
    }
}