using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleCollision : MonoBehaviour
{
void Start()
    {
        gameMagagerOne = FindObjectOfType<GameMagagerOne>();
    }
public GameMagagerOne gameMagagerOne;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Collision detected with Player");
            // Perform actions here
            gameMagagerOne.EndGame();
            
        }

        
    }
}
