using UnityEngine;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    public Text finalScoreText;

    void Start()
    {
        // Sækir og birtir lokastigið úr PlayerPrefs
        if (finalScoreText != null)
        {
            int finalScore = PlayerPrefs.GetInt("FinalScore", 0);
            finalScoreText.text = "Your Final Score: " + finalScore; // Birtir logastig á endaskjá
        }
    }
}
