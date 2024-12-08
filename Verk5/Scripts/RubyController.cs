using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RubyController : MonoBehaviour
{
    public float speed = 5f;
    public int maxLives = 3;
    public int currentLives;
    public int score = 0;

    public Text livesText;
    public Text scoreText;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentLives = maxLives;
        UpdateUI();
    }

    void Update()
    {
        // Hreyfing
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = movement * speed;
    }

    public void TakeDamage(int damage)
    {
        currentLives -= damage;
        UpdateUI();
        if (currentLives <= 0) // Ef líf er 0
        {
            Die(); // Kallar á fallið "Die"
        }
    }

    public void AddLife(int life)
    {
        currentLives = Mathf.Min(currentLives + life, maxLives);
        UpdateUI(); // Uppfærir líf textann
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (livesText != null)
        {
            livesText.text = "Lives: " + currentLives;
        }

        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Endurstillir senu
    }
}