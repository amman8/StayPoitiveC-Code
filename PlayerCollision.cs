using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public Rigidbody rig;

    private void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstical")
        {

            Points.Score -= 1;
            Destroy(collisionInfo.gameObject);
        }

        if (collisionInfo.collider.tag == "Point")
        {
            Points.Score += 1;
            Destroy (collisionInfo.gameObject);
        }

    }

}
