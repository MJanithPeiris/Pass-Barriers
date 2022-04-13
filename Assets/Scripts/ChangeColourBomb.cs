using UnityEngine;
using UnityEngine.UI;

public class ChangeColourBomb : MonoBehaviour
{
    public Color myColour;
    // store colours for coins and bomb coins
    public float rFloat = 0;
    public float gFloat = 0;
    public float bFloat = 0;
    public float aFloat = 0;

    public Renderer myrendere; // reference to bomb coin
    public bool isButtonClicked = true;

    // Start is called before the first frame update
    void Start()
    {
        rFloat = 0.5501f;
        gFloat = 0;
        bFloat = 0;
        aFloat = 1f;
        myrendere = gameObject.GetComponent<Renderer>();
    }

    // change the bomb coin colour when the button clicked
    public void changeColour()
    {
        if (isButtonClicked)
        {
            rFloat = 0.14148f;
            gFloat = 0.44409f;
            bFloat = 0.64059f;
            aFloat = 1f;
            isButtonClicked = false;
        }
        else
        {
            rFloat = 0.5501f;
            gFloat = 0;
            bFloat = 0;
            aFloat = 1f;
            isButtonClicked = true;
        }
        // set the colour according to the mode
        myColour = new Color(rFloat, gFloat, bFloat, aFloat);
        myrendere.sharedMaterial.color = myColour;
    }
}
