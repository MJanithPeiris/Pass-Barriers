using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColourCoin : MonoBehaviour
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
            rfloat = 0.83316f;
            gfloat = 0.67596f;
            bfloat = 0.05109f;
            afloat = 0.5f;

            flag = false;
        }
        else
        {
            rfloat = 0;
            gfloat = 0.46374f;
            bfloat = 0.04323f;
            afloat = 1;
            flag = true;
        }
        myColour = new Color(rfloat, gfloat, bfloat, afloat);
        myrendere.sharedMaterial.color = myColour;
    }
}
