using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Rigidbody
    private Rigidbody rb;
    // Teljari
    private int count;
    // Hreyfing spilara
    private float movementX;
    private float movementY;
    // Hra�i
    public float speed = 0;
    // Texti
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // N�r � og geymir rigidbody tengt spilara
        rb = GetComponent<Rigidbody>();
        // Setur upp teljara og stillir hann sem 0
        count = 0;
        // Uppf�rir "count" � skj�
        SetCountText();
        // Felur WinText �egar leikurinn byrjar
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        // Breytir input value � vector2
        Vector2 movementVector = movementValue.Get<Vector2>();
        // X og Y hnit
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        // Uppf�rir teljara �egar spilari fer yfir PickUp
        countText.text = "Count: " + count.ToString();
        // L�tur WinText vera s�nilegt og ey�ir enemy
        if(count >= 13)
        {
            winTextObject.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    private void FixedUpdate()
    {
        // Notar X og Y hnit �r onMove og setur sem 3D hreyfingu
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        // Setur afl � rigidbody til a� f�ra spilara
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        // G� hvort hluturinn sem spilari klessir � er me� "PickUp" tag
        if (other.gameObject.CompareTag("PickUp"))
        {
            // Slekkur � PickUp
            other.gameObject.SetActive(false);
            // H�kkar stigagj�fina
            count = count + 1;
            // Uppf�rir "count" � skj�
            SetCountText();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �egar "Enemy" drepur spilarann kemur upp "You Lose!"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Ey�a object
            Destroy(gameObject);
            // Uppf�ra winText � "You Lose!"
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
        }
    }

}