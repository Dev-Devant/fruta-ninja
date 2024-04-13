using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUI : MonoBehaviour{
    public TMP_Text score;
    public GameObject gameOver;
    private int realScore = 0;
    void Start()  {
        updateScore(0);
    }

    void Update() {
        
    }

    public void updateScore(int value){
        realScore += value;
        if(realScore < 0){
            gameOver.SetActive(true);
            return;
        }
        score.text = "Score: " + realScore;

    }
}
