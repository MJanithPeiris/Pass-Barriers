using UnityEngine;

public class Coins : MonoBehaviour
{

    public Transform transform;
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _speed;


    void Update()
    {
        transform.Rotate(_rotate * _speed * Time.deltaTime);
    }

    void OnTriggerEnter()
    {
        GameManager.numberofcoins += 1;
        Destroy(gameObject);

    }
}
