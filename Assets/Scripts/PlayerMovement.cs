using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float drivingForce = 1500f;
    public float sidewaysForce = 700f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, drivingForce*Time.deltaTime, ForceMode.Force);
        
        if ( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow) )
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }
        else if ( Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow) )
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }


    public void MoveLef()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void MoveRight()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
