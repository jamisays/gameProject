using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public playerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("hit obstacle");
            movement.enabled = false;
            FindObjectOfType<gameManager>().EndGame();
        }
    }

}

