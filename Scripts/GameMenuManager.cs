using UnityEngine;

public class GameMenuManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject unitPrefab;
    public GameObject playerParent;

    public void Start()
    {
        playerPrefab = Resources.Load<GameObject>("Prefabs/PlayerPanelPrefab");
        unitPrefab = Resources.Load<GameObject>("Prefabs/UnitPanelPrefab");
        playerParent = GameObject.Find("Player Parent");

        Director director = FindObjectOfType<Director>();
        int numPlayers = director.GetNumPlayers(); // get the number of players specified by the user

        for (int i = 0; i < numPlayers; i++)
        {
            Player player = director.GetPlayers()[i];
            director.GeneratePlayerUI(player, playerPrefab, playerParent, unitPrefab);

            // deactivate all panels after the first one
            if (i > 0)
            {
                GameObject panel = playerParent.transform.GetChild(i).gameObject;
                panel.SetActive(false);
            }
        }
    }
}


