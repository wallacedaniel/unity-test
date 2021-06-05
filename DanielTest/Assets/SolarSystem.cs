using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour

{
	//public GameObject Galaxy;

	public GameObject Planet;
	public Vector3 coordinates;
	public List<GameObject> planets;
	public List<Vector3> coordinatesInRange;

	public Star star;

    void Start()
    {

    	this.coordinates = this.transform.position;
    	List<GameObject> newPlanets = new List<GameObject>();
    	int planetsQty = Random.Range(3, 13);

        for(var i = 0; i < planetsQty; i++){
        	
        	var planet = Instantiate(Planet, new Vector3(this.coordinates.x + (i * 2), this.coordinates.y, this.coordinates.z), Quaternion.identity);	
        	newPlanets.Add(planet);
        }

        GameObject galaxyObject = GameObject.Find("Galaxy(Clone)");        
        var galaxy = galaxyObject.GetComponent<Galaxy>();      
        galaxy.known.Add(this);

        this.planets = newPlanets;


        for(var i = 0; i < galaxy.coordinates.Count; i++){     

    		//var newCoord = new Vector3(Random.Range(-1 * galaxyX, galaxyX), Random.Range(-1 * galaxyY, galaxyY), Random.Range(-1 * galaxyZ, galaxyZ));
    		//coordinates.Add(newCoord);

    		float dist = Vector3.Distance(this.coordinates, galaxy.coordinates[i]);
    		if (dist < 200) {                     // and is not the coordinate you are currently at!
    			this.coordinatesInRange.Add(galaxy.coordinates[i]);      
    		} 
    	}


    }

    void Update()
    {
        
    }

    // public void setStar(newStar){
    // 	this.star = newStar;
    // }
}


