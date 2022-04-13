using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText; // reference for score text

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManager.numberofcoins.ToString("0"); // set the score text to number of coins that player collects
    }
}
