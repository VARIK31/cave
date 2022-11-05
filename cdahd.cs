using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cdahd : MonoBehaviour
{
    public GameObject ball;
    public GameObject origin;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Instantiate(ball, Vector3(0,0,0));
        }

    }
}
