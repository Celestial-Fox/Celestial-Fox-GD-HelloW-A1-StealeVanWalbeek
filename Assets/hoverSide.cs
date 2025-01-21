using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverSide : MonoBehaviour
{
    float speed = 2f;
    float height = 1f;

    void Update()
    {
        Vector3 pos = transform.localPosition;
        float newZ = Mathf.Sin(Time.time * speed);
        transform.localPosition = new Vector3(pos.x, pos.y ,newZ * height);
    }
}
