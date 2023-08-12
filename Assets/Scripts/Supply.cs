using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supply : MonoBehaviour
{
    public delegate void EventDelegate();
    public event EventDelegate destroyEvent;

    //public float rotateSpeed;   

    // Update is called once per frame
    void Update()
    {
        //this.transform.Rotate(0.0f, rotateSpeed * Time.deltaTime, 0.0f, Space.World);
    }

    public void OnDestroy()
    {
        if (destroyEvent != null)
            destroyEvent();
    }
}
