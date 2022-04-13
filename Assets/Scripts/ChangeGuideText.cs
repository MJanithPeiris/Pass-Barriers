using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeGuideText : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text guideText;
    public bool flag = true;

    public void disableGuideText()
    {
        guideText.gameObject.SetActive(false);
    }

    public void changeText()
    {
        guideText.gameObject.SetActive(true);

        if (flag)
        {
            guideText.text = "Collect the Yellow coins and dodge the Blue coins hidden throughtout the level";

            flag = false;
        }
        else
        {
            guideText.text = "Collect the Green coins and dodge the Red coins hidden throughtout the level";
            flag = true;
        }
//
        Invoke("disableGuideText", 3f);
    }

}
