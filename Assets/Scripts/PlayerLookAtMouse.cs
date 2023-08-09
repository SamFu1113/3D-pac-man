using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAtMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(cameraRay, out hit, Mathf.Infinity))
        {
            this.transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
}
