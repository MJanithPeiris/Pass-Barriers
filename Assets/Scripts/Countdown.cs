using UnityEngine.UI;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public float countdownTime;
    [SerializeField] Text countdownText; // reference to count down text
    [SerializeField] Text scoreText; // reference to score text
    [SerializeField] Text guideText; // reference to guide text
    float startingTime = 3f;
    public PlayerMovement movement; // reference to player
    public bool isGuideTextDisable = false;

    private void Start()
    {
        movement.enabled = false; // disable the player movement in the begining
        countdownTime = startingTime;
    }

    // enable the player movement after the countdown lable
    public void enablePlayerMovement()
    {
        movement.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownTime > 0)
        {
            // do the count down from 3 to 0
            countdownTime -= 1 * Time.deltaTime;
            countdownText.text = countdownTime.ToString("0");
        }
        else
        {
            countdownText.text = "Go!";
            Destroy(countdownText, 1); // remove the countdown text lable

            if (!isGuideTextDisable) // disable the guide text lable
            {
                guideText.gameObject.SetActive(false);
                isGuideTextDisable = true;
            }
           
            scoreText.gameObject.SetActive(true); // enable the score text lable
            Invoke("enablePlayerMovement", 1f); // delay 1 second before enable the player movement
        }
    }
}
