using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI finalscore;
   
    public void Start()
    {
        
        if (SceneManager.GetActiveScene().buildIndex==3)
        {
            finalscore.text = "Final Score: " + PlayerMovment.count.ToString();
        }
        
    }
}
