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
    // Hraði
    public float speed = 0;
    // Texti
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Nær í og geymir rigidbody tengt spilara
        rb = GetComponent<Rigidbody>();
        // Setur upp teljara og stillir hann sem 0
        count = 0;
        // Uppfærir "count" á skjá
        SetCountText();
        // Felur WinText þegar leikurinn byrjar
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        // Breytir input value í vector2
        Vector2 movementVector = movementValue.Get<Vector2>();
        // X og Y hnit
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        // Uppfærir teljara þegar spilari fer yfir PickUp
        countText.text = "Count: " + count.ToString();
        // Lætur WinText vera sýnilegt og eyðir enemy
        if(count >= 13)
        {
            winTextObject.SetActive(true);
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    private void FixedUpdate()
    {
        // Notar X og Y hnit úr onMove og setur sem 3D hreyfingu
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        // Setur afl á rigidbody til að færa spilara
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        // Gá hvort hluturinn sem spilari klessir á er með "PickUp" tag
        if (other.gameObject.CompareTag("PickUp"))
        {
            // Slekkur á PickUp
            other.gameObject.SetActive(false);
            // Hækkar stigagjöfina
            count = count + 1;
            // Uppfærir "count" á skjá
            SetCountText();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Þegar "Enemy" drepur spilarann kemur upp "You Lose!"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Eyða object
            Destroy(gameObject);
            // Uppfæra winText í "You Lose!"
            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
        }
    }

}