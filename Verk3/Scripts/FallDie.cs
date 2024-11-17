using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position.y <= -1)// Spilari dettur af ground
        {
            Restart();
        }
    }
    public void Restart()
     {
         SceneManager.LoadScene(2); // Game over skjár
     }
}
