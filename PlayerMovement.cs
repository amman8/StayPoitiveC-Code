using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public int Forward_Force = 2000;
    public int Side_Force = 20;


    void FixedUpdate()
    {
        rb.AddForce(0,0, Forward_Force*Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-Side_Force * Time.deltaTime, 0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(Side_Force * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            GetComponent<GameManage>().EndGame();
        }

    }
}
