using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColourCoin : MonoBehaviour
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
        
        rFloat = 0;
        gFloat = 0.46374f;
        bFloat = 0.04323f;
        aFloat = 1;
        myrendere = gameObject.GetComponent<Renderer>();
    }



    // Update is called once per frame
    public void changeColour()
    {
        if (flag)
        {
            rFloat = 0.83316f;
            gFloat = 0.67596f;
            bFloat = 0.05109f;
            aFloat = 0.5f;

            flag = false;
        }
        else
        {
            

            rFloat = 0;
            gFloat = 0.46374f;
            bFloat = 0.04323f;
            aFloat = 1;

            flag = true;
        }
        myColour = new Color(rFloat, gFloat, bFloat, aFloat);
        myrendere.sharedMaterial.color = myColour;
    }
}
