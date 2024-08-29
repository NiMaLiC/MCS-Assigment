using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public GameMagagerOne gameMagagerOne;

    // Start is called before the first frame update
    void Start()
    {
        gameMagagerOne = FindObjectOfType<GameMagagerOne>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        

        // Check if the collision is with the player
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Player reached the goal!");
            GameMagagerOne.score=GameMagagerOne.score+10;
             PlayerPrefs.SetInt("PlayerScore",  GameMagagerOne.score);
            PlayerPrefs.Save(); // Ensure data is written to disk
            gameMagagerOne.LoadNextLevel();
        }
    }
}
