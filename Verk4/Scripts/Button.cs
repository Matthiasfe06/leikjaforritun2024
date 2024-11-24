using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Takki : MonoBehaviour
{
    public void Startscreen()
    {
        SceneManager.LoadScene(1);
    }

    public void End()
    {
        SceneManager.LoadScene(0);
    }

}