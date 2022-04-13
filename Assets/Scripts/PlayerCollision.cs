using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // to get reference to player

    [SerializeField] ParticleSystem fire = null; // reference to particles

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") // check player hits with a obstacle 
        {
            fire.Play(); // start animation of particle
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame(); // end the game
        }
        if (collisionInfo.collider.tag == "Bomb") // check player hits with bomb
        {
            fire.Play(); // start animation of particle
            movement.enabled = false; // to stop the player movement
            FindObjectOfType<GameManager>().EndGame(); // end gane
            Destroy(gameObject); // remove the bomb coin
        }
    }
}
