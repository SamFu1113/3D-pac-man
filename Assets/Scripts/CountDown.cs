using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public int countdownTime;
    GameObject num;
    public TextMesh text;
    PlayerMove move;
    FollowPlayer ghost_move;

    // Start is called before the first frame update
    public void Start()
    {
        num = GameObject.FindGameObjectWithTag("N3");
        text = num.GetComponent<TextMesh>();
        
        StartCoroutine(CountDownStart());
    }

    IEnumerator CountDownStart()
    {
        while(countdownTime > 0)
        {
            text.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        text.text = "GO";
        yield return new WaitForSeconds(1f);
        move = FindObjectOfType<PlayerMove>();
        ghost_move = FindObjectOfType<FollowPlayer>();
        move.make_move();
        ghost_move.make_ghost_move();
        num.SetActive(false);
    }
}
