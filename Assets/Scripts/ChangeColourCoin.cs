using UnityEngine;

public class ChangeColourCoin : MonoBehaviour
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
        rFloat = 0;
        gFloat = 0.46374f;
        bFloat = 0.04323f;
        aFloat = 1;
        myrendere = gameObject.GetComponent<Renderer>();
    }

    // change the bomb coin colour when the button clicked
    public void changeColour()
    {
        if (isButtonClicked)
        {
            rFloat = 0.83316f;
            gFloat = 0.67596f;
            bFloat = 0.05109f;
            aFloat = 0.5f;
            isButtonClicked = false;
        }
        else
        {
            rFloat = 0;
            gFloat = 0.46374f;
            bFloat = 0.04323f;
            aFloat = 1;
            isButtonClicked = true;
        }
        // set the colour according to the mode
        myColour = new Color(rFloat, gFloat, bFloat, aFloat);
        myrendere.sharedMaterial.color = myColour;
    }
}
