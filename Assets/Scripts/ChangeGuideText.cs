using UnityEngine.UI;
using UnityEngine;

public class ChangeGuideText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text guideText; // reference to giud text

    public ChangeColourBomb changeColourBomb;
    public bool isButtonClicked = true;

    public void disableGuideText()
    {
        guideText.gameObject.SetActive(false); // disable the visibility of guide text lable
    }

    public void changeText()
    {
        guideText.gameObject.SetActive(true); // enable the visibility of guide text lable

        // display the message according to the colour blind mode
        if (isButtonClicked)
        {
            guideText.text = "Collect the Yellow coins and dodge the Blue coins hidden throughtout the level";
            isButtonClicked = false;
        }
        else
        {
            guideText.text = "Collect the Green coins and dodge the Red coins hidden throughtout the level";
            isButtonClicked = true;
        }
        Invoke("disableGuideText", 3f); // make a 3 second delay before disable the visibility of guide text lable
    }
}