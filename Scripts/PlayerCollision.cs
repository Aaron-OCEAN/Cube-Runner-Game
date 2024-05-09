
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Rigidbody rigid;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obsticale")
        {
            rigid = GetComponent<Rigidbody>();
            rigid.freezeRotation = false;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
