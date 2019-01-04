using UnityEngine;

public class playerMovement : MonoBehaviour {


    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 600f;

    // Update is called once per frame
    void Update() {
        rb.useGravity = true;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
