using UnityEngine;

public class Coins : MonoBehaviour
{

    [SerializeField] private Vector3 rotate;
    [SerializeField] private float speed;


    void Update()
    {
        transform.Rotate(rotate * speed * Time.deltaTime); // rotate the coin
    }

    void OnTriggerEnter()
    {
        GameManager.numberOfCoinsCollect += 1; // when player colloect a coin add it to the score
        Destroy(gameObject); // remove that coin from the scene

    }
}
