using UnityEngine;

public class Frog : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController player = other.GetComponent<RubyController>();
        if (player != null)
        {
            player.TakeDamage(damage); // Tekur lífstig af spilara
        }
    }
}