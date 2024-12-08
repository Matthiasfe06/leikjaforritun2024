using UnityEngine;

public class Berry : MonoBehaviour
{
    public int life = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController player = other.GetComponent<RubyController>();
        if (player != null)
        {
            player.AddLife(life); //Bætir við lífi
            Destroy(gameObject); // Eyðir beri
        }
    }
}