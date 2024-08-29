using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
            // Load player level and score from PlayerPrefs
        int level = PlayerPrefs.GetInt("PlayerLevel", 1); // Default level to 1 if not found
        SceneManager.LoadScene("Level"+level);
 // Replace "Level1" with your level scene name
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}