using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorecount : MonoBehaviour
{
    int score = 0;
    private PlayerController playerControllerScript;
    private TextMeshProUGUI textMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        textMeshProUGUI= gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            score++;
        }
    }
    private void LateUpdate()
    {
        textMeshProUGUI.text = "Distance: " + score/100;
    }
}
