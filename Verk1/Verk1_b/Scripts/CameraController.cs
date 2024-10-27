using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Setur spilara sem focus
    public GameObject player;
    // Fjærlægð milli myndavélar og spilara
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Reiknar offset milli staðsetningu mindavélar og spilara
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Heldur sama offsetti á meðan leikurinn er i gangi
        transform.position = player.transform.position + offset;
    }
}
