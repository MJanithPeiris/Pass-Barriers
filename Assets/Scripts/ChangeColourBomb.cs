using UnityEngine;
using UnityEngine.UI;

public class ChangeColourBomb : MonoBehaviour
{
    public Color myColour;
    public float rFloat = 0;
    public float gFloat = 0;
    public float bFloat = 0;
    public float aFloat = 0;
    public Renderer myrendere;
    public bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        rFloat = 0.5501f;
        gFloat = 0;
        bFloat = 0;
        aFloat = 1f;
        myrendere = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    public void changeColour()
    {
        if (flag)
        {
            rFloat = 0.14148f;
            gFloat = 0.44409f;
            bFloat = 0.64059f;
            aFloat = 1f;

            flag = false;
        }
        else
        {
            rFloat = 0.5501f;
            gFloat = 0;
            bFloat = 0;
            aFloat = 1f;
            flag = true;
        }
        myColour = new Color(rFloat, gFloat, bFloat, aFloat);
        myrendere.sharedMaterial.color = myColour;
    }
}
