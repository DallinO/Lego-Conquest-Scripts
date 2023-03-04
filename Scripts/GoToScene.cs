using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public void Scene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
