using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universe : MonoBehaviour
{
    public GameObject Galaxy; 
    public GameObject Player; 

    void Start()
    {
    	Instantiate(Galaxy, new Vector3(0, 0, 0), Quaternion.identity);
    	Instantiate(Player, new Vector3(0, 0, 0), Quaternion.identity); 

	   	GameObject playerObject = GameObject.Find("FirstPerson-AIO");
	   	GameObject playerObjectGrandChild = playerObject.transform.GetChild(0).GetChild(0).gameObject;
	   	Camera playerCamera = playerObjectGrandChild.GetComponent("Camera") as Camera;   

	   	GameObject UICameraObject = GameObject.Find("UICamera");
	   	Camera UICamera = UICameraObject.GetComponent("Camera") as Camera; 

	   	playerCamera.enabled = true;
	    UICamera.enabled = false;
    }

    void Update()
    {
        
    }
}


	// add stars to the solar system
	// stars and planets generate texture and better positions and compose camera

	// unity textures and unity ui