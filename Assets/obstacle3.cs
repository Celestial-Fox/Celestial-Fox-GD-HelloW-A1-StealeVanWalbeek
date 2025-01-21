using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(-60, 1, 20); ;

    }
}
