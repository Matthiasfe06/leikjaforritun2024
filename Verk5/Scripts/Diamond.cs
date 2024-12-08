using UnityEngine;

public class Diamond : MonoBehaviour
{
    public int points = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController player = other.GetComponent<RubyController>();
        if (player != null)
        {
            player.AddScore(points); // Bætir við stigi
            Destroy(gameObject); // Eyðir demanti
        }
    }
}