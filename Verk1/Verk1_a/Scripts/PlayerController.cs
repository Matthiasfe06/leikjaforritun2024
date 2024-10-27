using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Stjórnar hraða bíls
    private float speed = 20.0f;
    // Stjórnar beygju hraða bíls
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        // Nær í lárétta ásinn
        horizontalInput = Input.GetAxis("Horizontal");

        // Nær í lóðrétta ásinn
        forwardInput = Input.GetAxis("Vertical");

        // Lætur bílinn fara áfram
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Beygju hraði
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
