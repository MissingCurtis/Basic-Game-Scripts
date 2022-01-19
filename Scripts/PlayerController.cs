using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private class
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horizontalinput;
    private float forwardinput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");

        // We move the vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
        // We turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalinput);
    }
}
