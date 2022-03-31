using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Highscore : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    // Start is called before the first frame update

    public void Start()
    {
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("score");
    }
    public void CheckScore(int newscore)
        {
        if(PlayerPrefs.GetInt("score") < newscore)
            PlayerPrefs.SetInt("score", newscore);
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("score");
        }
}
