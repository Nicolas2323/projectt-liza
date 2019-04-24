using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    public Transform theDest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().transform.localScale = Vector3(1.0f, 1.0f, 1.0f);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("destination").transform;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            //GetComponent<Rigidbody>().transform.localScale = Vector3(1.0f, 1.0f, 1.0f);
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
        }

    }

    //private Vector3 Vector3(float v1, float v2, float v3)
    //{
    //    throw new NotImplementedException();
    //}
}
