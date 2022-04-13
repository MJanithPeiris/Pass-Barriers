using UnityEngine;

public class Bombs : MonoBehaviour
{
    public PlayerMovement movement; // refetence to player
    [SerializeField] ParticleSystem fire = null; // reference to particles
    
    [SerializeField] private Vector3 rotate;
    [SerializeField] private float speed;

    void Update()
    {
        transform.Rotate(rotate * speed * Time.deltaTime); // rotate the bomb coin
    }

    void OnTriggerEnter()
    {
        fire.Play(); // start animation of particle
        movement.enabled = false; // stop player movement
        Destroy(gameObject); // distroy the coin
        FindObjectOfType<GameManager>().EndGame(); // stop the game level
    }
}
