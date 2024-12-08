using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController player = other.GetComponent<RubyController>();
        if (player != null)
        {
            // Geymir lokastigið
            PlayerPrefs.SetInt("FinalScore", player.score);
            PlayerPrefs.Save();

            SceneManager.LoadScene(2);
        }
    }
}
