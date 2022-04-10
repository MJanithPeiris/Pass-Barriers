using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 4000f;
    public float sidewayForce = 1000f;
    private Touch touch;
    public bool touchonl = false;
    public bool touchonr = false;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }


        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touchonl)
            {
                rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (touchonr)
            {
                rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }


            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2)
                        // rb.velocity = new Vector3(-movespeed, 0f, 0f);
                        //rb.AddForce(-sidewayforce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
                        touchonl = true;

                    if (touch.position.x > Screen.width / 2)
                        //rb.velocity = new Vector3(movespeed, 0f, 0f);
                        // rb.AddForce(sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                        touchonr = true;

                    break;
                case TouchPhase.Ended:
                    //rb.velocity = new Vector3(0f, 0f, 0f);
                    touchonr = false;
                    touchonl = false;
                    break;
            }
        }
    }
}
