using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManger : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("遊戲場景");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
