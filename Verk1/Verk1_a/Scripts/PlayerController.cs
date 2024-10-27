using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Stj�rnar hra�a b�ls
    private float speed = 20.0f;
    // Stj�rnar beygju hra�a b�ls
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
        // N�r � l�r�tta �sinn
        horizontalInput = Input.GetAxis("Horizontal");

        // N�r � l��r�tta �sinn
        forwardInput = Input.GetAxis("Vertical");

        // L�tur b�linn fara �fram
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Beygju hra�i
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
