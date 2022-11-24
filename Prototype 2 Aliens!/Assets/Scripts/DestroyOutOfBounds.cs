using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        // Displays end message on the log terminal when the game starts
        Debug.Log("WARNING!, several enemies approaching! Defend Earth at all cost!");
    }

    // Update is called once per frame
    void Update()
    {
        // Deletes rocket and enemy prefabs when leaving the specified scene location
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            // Displays end message on the log terminal when an enemy prefab reaches the bottom 
            Debug.Log("Game Over!, The aliens have invaded Earth!");
            Destroy(gameObject);

            // calls the QuitGame function
            QuitGame();
        }
    }
    // Ends the game preview in Unity 
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
