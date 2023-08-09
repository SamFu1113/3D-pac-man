using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Transform player;

    public bool CanMove = false;

    public bool Fast = false;

    public float moveSpeed ;
    public Rigidbody rb;
    public Vector3 movement;

    Scene m_Scene;
    string sceneName;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
    }

private void Update()
    {
        // 取得WASD數據
        if (CanMove)
        {

            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            // 取得Vector3(LR value, 0, ForwardAndBack value)
            movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            rb.AddForce(movement * moveSpeed);
            if (Fast)
            {
                moveSpeed += 50f* Time.deltaTime;
            }
            else 
            {
                if (sceneName == "HardScene")
                {
                    moveSpeed = 60f;
                }
                else if (sceneName == "MediumScene")
                {
                    moveSpeed = 80f;
                }
                else if (sceneName == "EasyScene")
                {
                    moveSpeed = 100f;
                }

            }
        }
    }

    public void make_move()
    {
        CanMove = true;
    }
    public void make_unmove()
    {
        CanMove = false;
    }
    public void move_faster()
    {
        Fast = true;
    }
    public void unmove_faster()
    {
        Fast = false;
    }
}
