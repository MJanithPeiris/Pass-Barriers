using UnityEngine;

public class Bombs : MonoBehaviour
{
    public PlayerMovement movement;
    [SerializeField] ParticleSystem fire = null;
    void OnTriggerEnter()
    {
        fire.Play();
        movement.enabled = false;
        //        GameManager.numberofcoins += 1;
        Destroy(gameObject);
        FindObjectOfType<GameManager>().EndGame();

    }
}
