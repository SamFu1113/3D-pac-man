using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ghost_back_origin : MonoBehaviour
{

    public NavMeshAgent agent;
    Vector3 originalPos;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = agent.transform.position;
    }
    void OnTriggerEnter(Collider playerrr)
    {
        Debug.Log("Ghost Reset");
        //SceneManager.LoadScene("DemoScene");
        agent.Warp(originalPos);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
