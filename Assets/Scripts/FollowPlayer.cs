using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // reference to player
    public Vector3 offset; // get vector3 for store a position to place the AR camera
 
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; // make the camera follow the player
    }
}
