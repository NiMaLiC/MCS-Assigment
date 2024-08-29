using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMagagerOne : MonoBehaviour
{
    
    public Transform player;
    public Transform goal;

     public static  int level;
    public  static int score;

    public string nextLeveleGameName;


    public void EndGame() {
        Debug.Log("Game Over....");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Start is called before the first frame update
    void Start()
    {
         LoadPlayerData();
        level = PlayerPrefs.GetInt("PlayerLevel", 1); // Default level to 1 if not found
        score = PlayerPrefs.GetInt("PlayerScore", 0); // Default score to 0 if not found
         

    }
  

    // Update is called once per frame
    void Update()
    {
        

        if (player.position.y < 0) {
            EndGame();
        }
    }


    public  void LoadNextLevel(){
        level = level+1;
        nextLeveleGameName="Level"+level;
         // Save player level and score to PlayerPrefs
        PlayerPrefs.SetInt("PlayerLevel", level);
        PlayerPrefs.Save(); // Ensure data is written to disk
        SceneManager.LoadScene(nextLeveleGameName);
    }

    public void SavePlayerData()
    {
        // Save player level and score to PlayerPrefs
        PlayerPrefs.SetInt("PlayerLevel", level);
        PlayerPrefs.SetInt("PlayerScore", score);
        PlayerPrefs.Save(); // Ensure data is written to disk
    }

    public void LoadPlayerData()
    {
        // Load player level and score from PlayerPrefs
        level = PlayerPrefs.GetInt("PlayerLevel", 1); // Default level to 1 if not found
        score = PlayerPrefs.GetInt("PlayerScore", 0); // Default score to 0 if not found

        Debug.Log($"Loaded Player Data - Level: {level}, Score: {score}");
    }


}
