using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Transform playerPosition;
    public float size = 5;


    // Use this for initialization
    void Start()
    {
        this.GetComponent<Camera>().orthographicSize = size;
    }


    // Update is called once per frame
    void Update()
    {
        float zkeys = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Q)) // Change From Q to anyother key you want
        {
            size = size + 1 * Time.deltaTime;
            if (size > 8)
            {
                size = 8; // Max size
            }
        }
    }
}
