using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Director : MonoBehaviour
{

/**********************
* ATTRIBUTES 
* ********************/

    [SerializeField] private int playerInt = 1;
    [SerializeField] private int day = 1;
    [SerializeField] private List<Player> players = new List<Player>();
    [SerializeField] private int numPlayers;

    /*** GAME OBJECTS ***/
    [SerializeField] public GameObject inputField;

    /*** CLASS OBJECTS ***/
    private Buy buy;
    private Attack att;
    private Move move;

    /*** STATIC ***/
    [SerializeField] private static Director instance;
    [SerializeField] public static Director Instance { get { return instance; } }

/**********************
* METHODS
* ********************/

    /*** SETTERS ***/
    public void SetNumPlayers()
    {
        numPlayers = Convert.ToInt32(inputField.GetComponent<TMP_InputField>().text);
    }

    public void SetPlayerName(string name)
    {
        Player player = new Player(playerInt, name);
        players.Add(player);
        playerInt ++;
    }

    public void AddUnits(int player) { players[player].AddCredits(150); }
    public void AddDay() { day++; }

    /*** GETTERS ***/
    public int GetNumPlayers() { return numPlayers; }
    public List<Player> GetPlayers() { return players; }


    /*** FUNCTIONS ***/
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void DestroyObject() { Destroy(gameObject); }

    public void GeneratePlayerUI(Player player, GameObject playerPanelPrefab, GameObject playerPanelParent, GameObject unitPanelPrefab)
    {
        GameObject playerPanel = Instantiate(playerPanelPrefab, playerPanelParent.transform);
        playerPanel.name = "Player " + player.GetNumber() + " Panel";

        TMP_Text playerName = playerPanel.transform.Find("Canvas/Panel/Name").GetComponent<TMP_Text>();
        playerName.text = player.GetName();

        TMP_Text playerHealth = playerPanel.transform.Find("Canvas/Panel/Health").GetComponent<TMP_Text>();
        playerHealth.text = "Health: " + player.GetHealth();

        TMP_Text playerCredits = playerPanel.transform.Find("Canvas/Panel/Credits").GetComponent<TMP_Text>();
        playerCredits.text = "Credits: " + player.GetCredits();

        GameObject armyPanel = playerPanel.transform.Find("Canvas/Panel/UnitPanel").gameObject;

        if (player.GetArmySize() > 0)
        {
            foreach (Actor unit in player.GetArmy())
            {
                GameObject unitPanel = Instantiate(unitPanelPrefab, armyPanel.transform);
                unitPanel.name = unit.GetName() + " Panel";

                TMP_Text unitName = unitPanel.transform.Find("Canvas/Name").GetComponent<TMP_Text>();
                unitName.text = unit.GetName();

                TMP_Text unitHealth = unitPanel.transform.Find("Canvas/Health").GetComponent<TMP_Text>();
                unitHealth.text = "Health: " + unit.GetHealth();

                TMP_Text unitMovement = unitPanel.transform.Find("Canvas/Moves").GetComponent<TMP_Text>();
                unitMovement.text = "Movement: " + unit.GetMovement();
            }
        }
    }

}