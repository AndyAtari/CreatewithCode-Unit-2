using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    // Game objects are destroyed when they collide 
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

    }


}
