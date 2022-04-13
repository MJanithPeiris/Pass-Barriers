using UnityEngine;

public class Coins : MonoBehaviour
{

void OnTriggerEnter()
{
GameManager.numberofcoins += 1;
Destroy(gameObject);

}
}
