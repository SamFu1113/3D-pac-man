using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTarget : MonoBehaviour
{
    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    */




    //////////////////////////////////////////////////
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="target")
            Destroy(this.gameObject);
        Debug.Log("collision enter: " + this.transform.name);
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
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="target")
            Destroy(this.gameObject);
        Debug.Log("trigger enter: " + this.transform.name);
    }
    /*
    void OnTriggerStay(Collider other)
    {
        Debug.Log("trigger stay: " + other.transform.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger exit: " + other.transform.name);
    }
    */
}
