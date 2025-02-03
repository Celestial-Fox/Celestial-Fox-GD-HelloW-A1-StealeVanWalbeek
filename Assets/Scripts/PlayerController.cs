using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator mAnimator = new Animator();
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            mAnimator.SetTrigger("Hip_Hop_Dance");
        }
        //movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += -transform.right * 6 * Time.deltaTime;
        };

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.LeftArrow) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
            transform.position += -transform.right * 4 * Time.deltaTime;
        };

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * 6 * Time.deltaTime;
        };

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightArrow) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
            transform.position += transform.right * 4 * Time.deltaTime;
        };

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * 6 * Time.deltaTime;
            mAnimator.SetTrigger("Walk");

            
        };

        

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.UpArrow) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
            transform.position += transform.forward * 4 * Time.deltaTime;
            mAnimator.SetTrigger("Run");
        };



        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += -transform.forward * 6 * Time.deltaTime;
        };

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.DownArrow) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
            transform.position += -transform.forward * 4 * Time.deltaTime;
        };

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * 5 * Time.deltaTime;
        };

        float mouseXmovement = Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseXmovement * 5, 0);

    }
}
