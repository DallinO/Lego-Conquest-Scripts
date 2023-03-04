using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public Director director;
    public GameObject textDisplay;
    void Start()
    {
        director = FindObjectOfType<Director>();
        textDisplay.GetComponent<TMP_Text>().text = director.GetPlayers()[0].GetName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
