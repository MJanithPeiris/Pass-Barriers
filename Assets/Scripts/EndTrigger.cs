using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager; // reference to the game manager
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
