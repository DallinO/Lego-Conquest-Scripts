using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerNameInput : MonoBehaviour
{
    public GameObject inputField;
    public Button nextButton;

    private int currentPlayerNumber = 1;
    private int totalPlayers;

    private void Start()
    {
        Director director = FindObjectOfType<Director>();
        totalPlayers = director.GetNumPlayers();
        inputField.GetComponent<TMP_InputField>().placeholder.GetComponent<TextMeshProUGUI>().text = $"Enter player {currentPlayerNumber}'s name";
        nextButton.onClick.AddListener(OnNextButtonClick);
    }

    private void OnNextButtonClick()
    {
        Director director = FindObjectOfType<Director>();
        string name = inputField.GetComponent<TMP_InputField>().text.Trim();

        if (name.Length > 0)
        {
            director.SetPlayerName(name);

            if (currentPlayerNumber < totalPlayers)
            {
                currentPlayerNumber++;
                inputField.GetComponent<TMP_InputField>().text = "";
                inputField.GetComponent<TMP_InputField>().placeholder.GetComponent<TextMeshProUGUI>().text = $"Enter player {currentPlayerNumber}'s name";
            }
            else
            {
                // All players have been entered, hide the input field and button
                SceneManager.LoadScene("Game Menu");
            }
        }
    }
}
