using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public static int numberofcoins = 0;
    public Renderer coin;
    public Renderer bomb;
    public float rfloat = 0;
    public float gfloat = 0;
    public float bfloat = 0;
    public float afloat = 0;
    public Color myColour;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        numberofcoins = 0;
        rfloat = 0;
        gfloat = 0.46374f;
        bfloat = 0.04323f;
        afloat = 1;
        //coin = gameObject.GetComponent<Renderer>();
        myColour = new Color(rfloat, gfloat, bfloat, afloat);
        coin.sharedMaterial.color = myColour;
        rfloat = 0.5501f;
        gfloat = 0;
        bfloat = 0;
        afloat = 1f;
        //bomb = gameObject.GetComponent<Renderer>();
        myColour = new Color(rfloat, gfloat, bfloat, afloat);
        bomb.sharedMaterial.color = myColour;
    }

}
