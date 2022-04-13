using UnityEngine;
using UnityEngine.UI;

public class ChangeColourBomb : MonoBehaviour
{
    public Color myColour;
    public float rfloat = 0;
    public float gfloat = 0;
    public float bfloat = 0;
    public float afloat = 0;
    public Renderer myrendere;
    public bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        rfloat = 0.5501f;
        gfloat = 0;
        bfloat = 0;
        afloat = 1;
        myrendere = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    public void changeColour()
    {
        if (flag)
        {
            rfloat = 0.14148f;
            gfloat = 0.44409f;
            bfloat = 0.64059f;
            afloat = 1f;

            flag = false;
        }
        else
        {
            rfloat = 0.5501f;
            gfloat = 0;
            bfloat = 0;
            afloat = 1;
            flag = true;
        }
        myColour = new Color(rfloat, gfloat, bfloat, afloat);
        myrendere.sharedMaterial.color = myColour;
    }
}
