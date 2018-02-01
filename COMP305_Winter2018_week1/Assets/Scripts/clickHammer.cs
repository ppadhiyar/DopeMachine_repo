using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickHammer : MonoBehaviour {
    /*
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    //Input
	void Update () {
		
	}

    //Guarenteed to run a specific interval
    // Physics (i.e. things that are time dependent)
    void FixedUpdate()
    {
        
    } */

    public GameObject batmanDude;
    public Sprite newImage;

    void Start()
    {
       //batmanDude.velocity = new Vector2(5, 0);
       //Rigidbody2D theBody = batmanDude.GetComponent<Rigidbody2D>();
       //theBody.velocity = new Vector2(5, 0);
    }
    void Update()
    {
        
    }
    //Executes when a mouse down event 
    void OnMouseDown()
    {
        //GameObject gObject = GameObject.Find("Batman_Empty_Back");
        //Debug.Log(batmanDude);

        SpriteRenderer eRend = batmanDude.GetComponent<SpriteRenderer>();
        eRend.sprite = newImage;
    }
}
