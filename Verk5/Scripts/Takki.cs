using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Takki : MonoBehaviour
{
    public void Byrja()
    {
        SceneManager.LoadScene(1);
    }

    public void Enda()
    {
        SceneManager.LoadScene(0);
    }
}
