using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCloseupTrigger : MonoBehaviour {


    public Camera mainCamera;
    public Camera closeupCamera;

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            mainCamera.enabled = false;
            closeupCamera.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            mainCamera.enabled = true;
            closeupCamera.enabled = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        
    }
}
