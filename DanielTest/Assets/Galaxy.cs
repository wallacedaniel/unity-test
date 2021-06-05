using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Galaxy : MonoBehaviour

{
	//public GameObject PlayerCamera;
	//public Camera SolarSystemCamera;
	public List<Vector3> coordinates;
	public List<Vector3> coordinatesInRange;
	public List<SolarSystem> known;
	public GameObject Star; 

    void Start()
    {
       	var galaxyX = 1000.0f;
       	var galaxyY = 1000.0f;
       	var galaxyZ = 1000.0f;
       	var starCount = 2000;
       	var origin = new Vector3(0, 0, 0);

       	List<Vector3> newCoordinates = new List<Vector3>();
       	List<Vector3> newCoordinatesInRange = new List<Vector3>();

       	this.known.Clear();
       	this.coordinates.Clear(); 
       	this.coordinatesInRange.Clear(); 

       	// create new coordinates and determine those in range
    	for(var i = 0; i < starCount; i++){

    		var newCoord = new Vector3(Random.Range(-1 * galaxyX, galaxyX), Random.Range(-1 * galaxyY, galaxyY), Random.Range(-1 * galaxyZ, galaxyZ));
    		newCoordinates.Add(newCoord);


    		float dist = Vector3.Distance(origin, newCoord);
    		if (dist < 200) {
    			newCoordinatesInRange.Add(newCoord);      
    		} 
    	}
    	this.coordinates = newCoordinates;
    	// for each coordinate instantiate a star
    	for(var i = 0; i < this.coordinates.Count; i++){

    		GameObject star = Instantiate(Star, new Vector3(this.coordinates[i].x, this.coordinates[i].y, this.coordinates[i].z), Quaternion.identity);
    	}

    	this.coordinatesInRange = newCoordinatesInRange;
    }

    void Update()
    {
    	// shimmer the stars ...    
    }

}



		//  apply the solar coords to the planets ... and the planet coords to the moon
		// add star to the solar syustem  

		// figure out the camera ...  in stars .. n star text ..





