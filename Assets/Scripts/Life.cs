using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    Text lifeText;
    int life = 3;



    public GameObject canvas;

    PlayerMove move;
    // Start is called before the first frame update
    void Start()
    {
        lifeText = this.GetComponent<Text>();
        lifeText.text = "3";
    }

    public void addLife()
    {
        life += 1;
        setLifeText();
    }

    public void subLife()
    {
        life -= 1;
        setLifeText();
    }

    public void setLifeText()
    {
        lifeText.text = life.ToString();
    }
    public void gameover()
    {
        if (life <= 0)
        {
            Debug.Log("GAMEOVER");
            move = FindObjectOfType<PlayerMove>();
            move.make_unmove();
            canvas.SetActive(true);
        }
    }
}
