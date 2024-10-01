using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Need Number");
        Debug.Log(GameManager.instance.number);

        scoreText.text = "TOTAL SCORE: " + GameManager.instance.number;
    }
}
