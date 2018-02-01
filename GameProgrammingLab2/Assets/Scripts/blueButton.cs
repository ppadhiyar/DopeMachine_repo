using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueButton : MonoBehaviour {

    public GameObject centsGold;
    public Sprite centsBlue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        SpriteRenderer change = centsGold.GetComponent<SpriteRenderer>();
        change.sprite = centsBlue;
    }
}
