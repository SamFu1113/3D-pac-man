using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectMoveToTarget : MonoBehaviour
{
    public Transform target;

    public Transform returnTarget;

    public float speed;

    public float waitForReturnTarget;

    Transform source;

    float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        source = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= waitForReturnTarget)
            source.localPosition = Vector3.MoveTowards(source.position, returnTarget.position, speed * Time.deltaTime);
        else
            source.localPosition = Vector3.MoveTowards(source.position, target.position, speed * Time.deltaTime);
    }
}
