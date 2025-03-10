using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    float speed = 2f;
    float height = 0.25f;

    void Update()
    {
        Vector3 pos = transform.localPosition;
        float newY = Mathf.Sin(Time.time * speed);
        transform.localPosition = new Vector3(pos.x, newY * height, pos.z);
    }
}
