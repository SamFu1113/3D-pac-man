using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour
{
    
    
    GameObject player;
   

    public GameObject[] ghosts;

    public bool CanMove = false;


    Scene m_Scene;
    string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        ghosts = GameObject.FindGameObjectsWithTag("Ghost");

        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove)
        {
            foreach (GameObject gg in ghosts)
            { 
                gg.GetComponent<NavMeshAgent>().SetDestination(player.transform.position); 
            }

        }
            
    
    }
    public void make_ghost_move()
    {
        CanMove = true;
    }
    public void scale_ghosts()
    {

        if (sceneName == "HardScene")
        {
            foreach (GameObject gg in ghosts)
            {
                gg.transform.localScale = new Vector3(0.4f, 5f, 0.45f);
            }
        }
        else if (sceneName == "MediumScene")
        {
            foreach (GameObject gg in ghosts)
            {
                gg.transform.localScale = new Vector3(0.2f, 4f, 0.25f);
            }
        }
        else if (sceneName == "EasyScene")
        {
            foreach (GameObject gg in ghosts)
            {
                gg.transform.localScale = new Vector3(0.15f, 3f, 0.2f);
            }

        }


    }
    public void unscale_ghosts()
    {
        if (sceneName == "HardScene")
        {
            foreach (GameObject gg in ghosts)
            {
                gg.transform.localScale = new Vector3(0.8f, 10f, 0.9f);
            }
        }
        else if (sceneName == "MediumScene")
        {
            foreach (GameObject gg in ghosts)
            {
                gg.transform.localScale = new Vector3(0.4f, 8f, 0.5f);
            }
        }
        else if (sceneName == "EasyScene")
        {
            foreach (GameObject gg in ghosts)
            {
                gg.transform.localScale = new Vector3(0.3f, 6f, 0.4f);
            }

        }
    }


}
