using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScripts : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
