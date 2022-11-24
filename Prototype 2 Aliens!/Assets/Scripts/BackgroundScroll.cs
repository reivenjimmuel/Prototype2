using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the ground terrain downwards
        transform.Translate(Vector3.back * speed * Time.deltaTime);

        // Resets the position of the ground after reaching the specified scene location
        if (transform.position.z < -101)
        {
            transform.position = startPosition;
        }
    }
}
