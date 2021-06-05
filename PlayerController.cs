using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 15.0f;
    public float xRange = 20.0f;
    public GameObject projectilePrefab;
    public float verticalInput;
    private float topPlayer = 5.0f;
    private float lowerPlayer = -10.0f;

    void Start()
    {

    }

    // Moves Player left/right, checks for boundaries, fires projectile on key down
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < lowerPlayer)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, lowerPlayer);
        }
        else if (transform.position.z > topPlayer)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, topPlayer);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Fire");
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
