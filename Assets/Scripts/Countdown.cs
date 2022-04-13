using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public float countdownTime;
    // public Text countdownDisplay;
    [SerializeField] Text countdownText;
    [SerializeField] Text scoreText;
    [SerializeField] Text guideText;
    float startingTime = 3f;
    public PlayerMovement movement;
    public bool isGuideTextDisable = false;

    private void Start()
    {
        movement.enabled = false;
        countdownTime = startingTime;
    }
    public void Downdate()
    {
        movement.enabled = true;
       
    }


    void Update()
    {

        if (countdownTime > 0)
        {
            countdownTime -= 1 * Time.deltaTime;
            countdownText.text = countdownTime.ToString("0");
        }
        else
        {
            countdownText.text = "Go!";
            Destroy(countdownText, 1);
            // countdownText.gameObject.SetActive(false);
            if (!isGuideTextDisable)
            {
                guideText.gameObject.SetActive(false);
                isGuideTextDisable = true;
            }
           //
            scoreText.gameObject.SetActive(true);
            Invoke("Downdate", 1f);

            //startingTime = 1 * Time.deltaTime;

        }

    }

}
