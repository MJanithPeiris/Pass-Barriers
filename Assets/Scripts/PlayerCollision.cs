using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    [SerializeField] ParticleSystem fire = null;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //fire.Enable();
          //  fire.Play();
            movement.enabled = false;
          //  FindObjectOfType<GameManager>().EndGame();

        }
    }
}
