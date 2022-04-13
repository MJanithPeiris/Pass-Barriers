using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI; // reference to level complete 
    public static int numberOfCoinsCollect = 0;

    public Renderer coin; // reference to coin
    public Renderer bomb; // reference to bomb coin
    // store colours for coins and bomb coins
    public float rFloat = 0;
    public float gFloat = 0;
    public float bFloat = 0;
    public float aFloat = 0;
    public Color myColour;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true); // show the level complete message
    }

    public void EndGame() // end the game and restart the level again
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay); // restart the level with a delay
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // to get the same level

        numberOfCoinsCollect = 0; // reset the coin count

        // set the coin 
        rFloat = 0;
        gFloat = 0.46374f;
        bFloat = 0.04323f;
        aFloat = 1f;
        myColour = new Color(rFloat, gFloat, bFloat, aFloat);
        coin.sharedMaterial.color = myColour;

        rFloat = 0.5501f;
        gFloat = 0;
        bFloat = 0;
        aFloat = 1f;
        myColour = new Color(rFloat, gFloat, bFloat, aFloat);
        bomb.sharedMaterial.color = myColour;
    }
}