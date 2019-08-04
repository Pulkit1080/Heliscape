using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text HighscoreText;
    public Text ScoreText;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        HighscoreText.text = PlayerPrefs.GetString("HighScore",0.ToString());
    }
    private void Update()
    {
        if (float.Parse(ScoreText.text) >= float.Parse(HighscoreText.text))
        {
            if (Player == null)
            {
                HighscoreText.text = ScoreText.text;

                PlayerPrefs.SetString("HighScore", HighscoreText.text);
            }
        }
    }

}
