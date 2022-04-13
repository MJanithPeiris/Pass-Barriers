using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // reference for player's rigidbody
    public float forwardForce = 2000f;
    public float sidewayForce = 50f;
    private Touch touch; // to get touch control
    public bool touchonLeft = false;
    public bool touchonRight = false;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // player movement with keyboard control
        if (Input.GetKey("d")) // to move right
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) // to move left
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }

        // if player goes out of bound then end the game
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        // player movement with touch control
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touchonLeft)
            {
                rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // add force to left if left side of the screen is touched
            }
            if (touchonRight)
            {
                rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // add force to right if right side of the screen is touched
            }

            // check whether the display is touched or not
            switch (touch.phase)
            {
                case TouchPhase.Began: // if display is touched 
                    if (touch.position.x < Screen.width / 2) // check which side of the screen is touched
                        touchonLeft = true; // if it is left

                    if (touch.position.x > Screen.width / 2)
                        touchonRight = true; // if it is right

                    break;

                case TouchPhase.Ended: // if display is not touched 
                    touchonRight = false;
                    touchonLeft = false;
                    break;
            }
        }
    }
}
