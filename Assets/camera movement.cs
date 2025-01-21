using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXmovement = Input.GetAxis("Mouse X");

        float mouseYmovement = Input.GetAxis("Mouse Y");

        transform.Rotate(-mouseYmovement * 2, 0, 0);
    }
}
