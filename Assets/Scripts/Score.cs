using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text gameOverScoreText;
    private float score;
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
        else if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverScoreText.text = ((int)score).ToString();
        }
    }
}
