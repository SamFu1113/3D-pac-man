using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;
    int score = 42;

    public GameObject canvas;
    //FailCanvas complete;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<Text>();
        scoreText.text = "42";
    }

  

    public void addScore()
    {
        score += 1;
        setScoreText();
    }

    public void subScore()
    {
        score -= 1;
        setScoreText();
    }

    public void setScoreText(){
        scoreText.text = score.ToString();
    }

    PlayerMove move;
    public Text WhateverTextThingy;  //Add reference to UI Text here via the inspector
    private float timeToAppear = 5f;
    private float timeWhenDisappear;

    public void gameWin()
    {
        if (scoreText.text == "0") 
        {
            Debug.Log("qqqqq");
            move = FindObjectOfType<PlayerMove>();
            move.make_unmove();
            canvas.SetActive(true);


            WhateverTextThingy.enabled = true;
            timeWhenDisappear = Time.time + timeToAppear;
            //complete = FindObjectOfType<FailCanvas>();
            //complete.showExitPanel();
        }
    }


    
    /*
    //Call to enable the text, which also sets the timer
    public void EnableText()
    {
        WhateverTextThingy.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
    }
    */
    //We check every frame if the timer has expired and the text should disappear
    void Update()
    {
        if (WhateverTextThingy.enabled && (Time.time >= timeWhenDisappear))
        {
            WhateverTextThingy.enabled = false;
        }
    }
}
