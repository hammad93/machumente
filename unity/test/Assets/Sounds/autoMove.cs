using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoMove : MonoBehaviour
{
    // Credits to Marcel
    public Vector3 direction;
    public float speed = 1;
    public Vector3 startingPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    	if (transform.position.x >= 100) {
    	    transform.position = startingPosition;
    	}
    	// Time.deltaTime makes it frame consistent otherwise speed would depend on the frame rate
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
