using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // reference for player's rigidbody
    public float forwardForce = 2000f;
    public float sidewayForce = 1000f;
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
                rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (touchonRight)
            {
                rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2)
                        touchonLeft = true;

                    if (touch.position.x > Screen.width / 2)
                        touchonRight = true;

                    break;

                case TouchPhase.Ended:
                    touchonRight = false;
                    touchonLeft = false;
                    break;
            }
        }
    }
}
