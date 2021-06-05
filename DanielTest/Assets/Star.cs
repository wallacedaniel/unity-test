using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{

	public GameObject SolarSystem;

	public Text txt;
	public bool inRange = false;
	public Vector3 coordinates;
	public string starType;
    public int temp;
    public float radius;
    public int mass;
    public float luminosity;

    // 2d ui canvas > render texture > display data ( construct and fix position  .. hide by default .. show on click .. x to close  .. display data)
    // render stage .. swap n save 
    // compose system and animate
    // select and travel and generate local
    // select display planet ui / data
    // selct to change scene > planet surface


    void Start()
    {

    	this.coordinates = this.transform.position;
    	float bodySize =  Random.Range(1, 5);
        this.transform.localScale = new Vector3(bodySize, bodySize, bodySize);

    	Renderer starRenderer;
    	starRenderer = GetComponent<Renderer>();
    	
        float starSelect = Random.Range(1, 100);
    	var colors = "red";

		if(starSelect > 10 && starSelect < 20){
			this.starType = "K";
			starRenderer.material.color = new Color(0,1,0,1);
			this.temp = 3200;
    		this.radius = 0.3f;
    		this.mass = 1;
    		this.luminosity = 0.2f;
    		colors = "red";
		}
		else if(starSelect < 20){
			this.starType = "G";
			starRenderer.material.color = new Color(0,1,0,1);
			this.temp = 5700;
    		this.radius = 0.3f;
    		this.mass = 1;
    		this.luminosity = 0.2f;
    		colors = "red";
		}
		else if(starSelect < 30){
			this.starType = "F";
			starRenderer.material.color = new Color(0,1,0,1);
			this.temp = 6500;
    		this.radius = 0.3f;
    		this.mass = 1;
    		this.luminosity = 0.2f;
    		colors = "red";
		}
		else if(starSelect < 40){
			this.starType = "A";
			starRenderer.material.color = new Color(1,0,0,1);
			this.temp = 8500;
    		this.radius = 0.3f;
    		this.mass = 1;
    		this.luminosity = 0.2f;
    		colors = "red";
		}
		else if(starSelect < 50){
			this.starType = "B";
			starRenderer.material.color = new Color(1,0,0,1);
			this.temp = 20000;
    		this.radius = 0.3f;
    		this.mass = 1;
    		this.luminosity = 0.2f;
    		colors = "red";
		}
  		else if(starSelect < 60){ 
			this.starType = "O";
			starRenderer.material.color = new Color(1,0,0,1);
			this.temp = 40000;
    		this.radius = 0.3f;
    		this.mass = 1;
    		this.luminosity = 0.2f;
    		colors = "red";
		}
		else if(starSelect < 70){
			this.starType = "D";
			starRenderer.material.color = new Color(1,0,0,1);
			this.temp = 80000;
    		this.radius = 0.3f;
    		this.mass = 1;
    		this.luminosity = 0.2f;
    		colors = "red";
		}
		else if(starSelect < 80){
			this.starType = "Giant";
			starRenderer.material.color = new Color(0,0,1,1);
			this.temp = 3000; //10000
    		this.radius = 0.3f;
    		this.mass = 1;
    		this.luminosity = 0.2f;
    		colors = "red";
		}
		else if(starSelect < 90){
			this.starType = "SuperGiant";
			starRenderer.material.color = new Color(0,0,1,1);
			this.temp = 4000; // 40000
    		this.radius = 0.3f;
    		this.mass = 1;
    		this.luminosity = 0.2f;
    		colors = "red";
		} else {
			this.starType = "M";
			this.temp = 3200;
			this.radius = 0.3f;
			this.mass = 1;
			this.luminosity = 0.2f;
			starRenderer.material.color = new Color(0,0,1,1);

		}

		GameObject galaxy = GameObject.Find("Galaxy(Clone)");        
		var galaxyScript = galaxy.GetComponent<Galaxy>();


		if(galaxyScript.coordinatesInRange.Contains(this.transform.position)){
			
			this.inRange = true;		
			txt.text = "type: " + starType;
			starRenderer.material.color = new Color(1,1,1,1);
		}  else {
    		txt.text = "";	
    	}

    }

    void Update()
    {
    		txt.transform.position = new Vector3(this.transform.position.x,this.transform.position.y, this.transform.position.z);

    }

    void OnMouseOver()
    {
   	    if(this.inRange == true){
   	    	
        }	
    }

    void OnMouseDown() {   


    	GameObject galaxyObject = GameObject.Find("Galaxy(Clone)");        
        var galaxy = galaxyObject.GetComponent<Galaxy>(); 

 
       
    	// for(var i = 0; i < galaxyScript.coordinatesInRange.Count; i++){

    	// }
    	
    	if(this.inRange == true){

    	  //or the length of galaxy.known  which is an array list 
    	var found = false;
    	foreach(var system in galaxy.known)
		{
		    if( system.coordinates == this.coordinates){
		    	found = true;
    		}
		}

		if(found == false){
			Instantiate(SolarSystem, new Vector3(this.coordinates.x, this.coordinates.y, this.coordinates.z), Quaternion.identity);
		}

   


	   	 //   	SolarSystemCamera.enabled = !SolarSystemCamera.enabled;
	     // 	testCam.enabled = !testCam.enabled;

		   	// GameObject playerObject = GameObject.Find("FirstPerson-AIO");
		   	// GameObject playerObjectGrandChild = playerObject.transform.GetChild(0).GetChild(0).gameObject;
		   	// Camera playerCamera = playerObjectGrandChild.GetComponent("Camera") as Camera;   

		   	GameObject UICameraObject = GameObject.Find("UICamera");
		   	Camera UICamera = UICameraObject.GetComponent("Camera") as Camera; 

		   	//playerCamera.enabled = false;
	        UICamera.enabled = true;
	        UICamera.transform.position = new Vector3(this.coordinates.x, this.coordinates.y, this.coordinates.z - 10);

	        

	        // SolarSystem newSystem = new SolarSystem(Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), )
	        // this should be a getter/setter rather than direct assignment? correct?
	        //newSystem.setStar(this);	

    	}






 	}
}







	    	// bring

	    	//GameObject testCam = testCamObj.GetComponent(Camera);
	    	//testCam.enabled = "false"

	    	//print(SolarSystemCamera.enabled.ToString());
	    	//print(testCam.enabled.ToString());



	    	// if(this.inRange == true){

/// when the mouse is HELD down .. bring the camera here (location) .. generate solar system in place and render in view ... then remove all.. but save in meomory

    	// GameObject child = PlayerCamera.transform.GetChild(0).gameObject;
    	// GameObject secondChild = child.transform.GetChild(0).gameObject;
    	// Camera mainCam = secondChild.GetComponent<Camera>();

    	//camera = GameObject.find("CameraNameGoesHere");

    	// print(mainCam.enabled.ToString()); 


    	// alternate to using find???
    	//   unity3d.com/learn/tutorials/topics/scripting/persistence-saving-and-loading-data


			//txt.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,10);
			//where posX Y Z is the position where you want to put your text.
		
			// GameObject highlight = GameObject.CreatePrimitive(PrimitiveType.Cube);
   //  	 	highlight.transform.position = this.transform.position;
   //  	 	float highlightSize =  bodySize + 1;
   //      	highlight.transform.localScale = new Vector3(highlightSize, highlightSize, highlightSize);
   //      	highlight.GetComponent<Renderer>().material.color = new Color(0,0,1,0.1f);

	//public Camera TestCamera;




	//have the script which instantiates the Prefab also assign the camera to the Canvas.\

// 	Litte improvement if you want camera rotation too (not only position)

// Vector3 v = Camera.mainCamera.transform.position - transform.position;

// v.x = v.z = 0.0f;

// transform.LookAt( Camera.mainCamera.transform.position - v );

// transform.rotation =(Camera.mainCamera.transform.rotation); // Take care about camera rotation



    	
    	

//     	 private Camera mainCam;

// and in Start() do

//  mainCam = Camera.main
// or FindObjectWithTag("$$anonymous$$ain Camera")


// Casting will not work, i.e. cannot cast a GameObject to a Camera. He has to use GetComponent<Camera>():

//  Camera mainCam = GameObject.Find("$$anonymous$$ain Camera").GetComponent<Camera>().
 


// avatar imagepako  mrcyangaming · Feb 17, 2018 at 11:47 AM 0
// In your statement Camera mainCam = GameObject.Find("$$anonymous$$ain Camera"); you do 2 things"

// You declare the variable mainCam to be of type Camera

// You assign the result of the GameObject.Find method to the mainCam variable

// However, the GameObject.Find method returns a GameObject. So, you are trying to assign a GameObject to a variable that can only accept a Camera. Hence the error you are getting.

// I think you will benefit to make use of the Unity Tutorials, especially the "Scripting" section.

// avatar imageAhmadSannan · Feb 21, 2018 at 06:53 PM 0
// @mrcyangaming all you need to do is that mainCam should be of type GameObject, and then if you want the camera u can use : mainCam.GetComponent() and now you have a reference to the camera component of the mainCam

    	//TestCamera.enabled = true;

    	// GameObject child = PlayerCamera.transform.GetChild(0).gameObject;
    	// GameObject secondChild = child.transform.GetChild(0).gameObject;
    	// Camera mainCam = secondChild.GetComponent<Camera>();
    	// mainCam.enabled = true;

    

        	

