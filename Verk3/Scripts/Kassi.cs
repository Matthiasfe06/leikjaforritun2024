using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kassi : MonoBehaviour
{
 
    public static int count=0;
    public GameObject sprenging;
    private TextMeshProUGUI countText;
    void Start()
    {
        countText = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        //sprenging= GetComponent<Explosion>
        count = 0;
        SetCountText();
    }
    private void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "bullet")
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            count = count + 1; //færð stig
            SetCountText(); //kallar í aðferðina
            Sprengin();
        }
    }
    void SetCountText() //hér er aðferðin
    {
        countText.text = "Score: " + count.ToString();
    }
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
    }
}
