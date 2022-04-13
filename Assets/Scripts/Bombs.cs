using UnityEngine;

public class Bombs : MonoBehaviour
{
    public PlayerMovement movement;
    [SerializeField] ParticleSystem fire = null;
    public Transform transform;
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(_rotate *_speed * Time.deltaTime);
    }

    void OnTriggerEnter()
    {
        fire.Play();
        movement.enabled = false;
        //        GameManager.numberofcoins += 1;
        Destroy(gameObject);
        FindObjectOfType<GameManager>().EndGame();

    }
}
