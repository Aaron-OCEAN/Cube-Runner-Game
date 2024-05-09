
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    // Adds a variable called forwardForce and sets it value
    // It is a float so that we can fine tune the number into the decimal points
    public float forwardForce = 1600;
    public float sidewaysForce = 30;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    // Unity prefers preferes a FixedUpdate when working with phisics.
    void FixedUpdate()
    {
        //rb. for the RigidBody
        //AddForce adds a force to the object in the RigidBody X, Y, Z 
        //Time.deltaTime ensures it is the same on every system because of different framerates
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            //only executed when the if conditionis met
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}