using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {
    public Camera mainCamera;
    public Camera RegionCamera;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            mainCamera.enabled = false;
            RegionCamera.enabled = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            mainCamera.enabled = true;
            RegionCamera.enabled = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {

    }
}
