using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = transform.position;
        pos.x = mousePos3D.x;
        if (pos.x < -1.9f)
        {
            pos.x = -1.9f;
        }
        if (pos.x > 1.9f)
        {
            pos.x = 1.9f;
        }
        transform.position = pos;
    }
}
