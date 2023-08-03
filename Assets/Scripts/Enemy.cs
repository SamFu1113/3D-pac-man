using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Score score;

    private void Start() {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    public delegate void EventDelegate();
    public event EventDelegate destroyEvent;

    public void OnDestroy()
    {
        if (destroyEvent != null)
            destroyEvent();
    }


    
    
}
