using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Score score;
    //public GameObject canvas;
    Life life;
    Vector3 originalPos;
    [SerializeField]
    private Transform[] waypoints;

    FollowPlayer scale_ghost;

    PlayerMove move_fast;

    private void Start(){

        //originalPos = gameObject.transform.position;

        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        life = GameObject.FindGameObjectWithTag("Life").GetComponent<Life>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Supply"){
            Debug.Log("~~Get Supply~~");
            Destroy(other.gameObject);
            score.subScore();
            score.gameWin();
        }
        else if (other.gameObject.tag == "Ghost")
        {
            //Debug.Log(other.transform.name+"!!!!!");
            //gameObject.transform.position = originalPos;
            //canvas.SetActive(true);
            int num = Random.Range(0, 2);
            gameObject.transform.position = waypoints[num].transform.position;
            life.subLife();
            life.gameover();
        }
        else if (other.gameObject.tag == "BigSupply")
        {
            Debug.Log("!!BIG!!");
            Destroy(other.gameObject);

            StartCoroutine(CountThreeSec());
        }
    }

    IEnumerator CountThreeSec()
    {
        scale_ghost = FindObjectOfType<FollowPlayer>();
        move_fast = FindObjectOfType<PlayerMove>();
        scale_ghost.scale_ghosts();
        move_fast.move_faster();
        yield return new WaitForSeconds(5f);
        scale_ghost.unscale_ghosts();
        move_fast.unmove_faster();
    }

    /*void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Enemy"){
            Destroy(other.gameObject);
            //score.subScore();
        }
        
        Debug.Log("Collsion enter: " + other.transform.name);
    }
    /*
    void OnCollisionStay(Collision other)
    {
        Debug.Log("collision stay: " + other.transform.name);
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("collision exit: " + other.transform.name);
    }
    */

    /*
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="target")
            Destroy(this.gameObject);
        Debug.Log("trigger enter: " + this.transform.name);
    }
    */
}
