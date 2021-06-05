using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

	public GameObject Moon;
	public Vector3 coordinates; 
	public Vector3 starCoordinates;
	public List<GameObject> moons;
	public string type;
	public int habitableLevel;
	public int civilizationLevel;
	public float PlanetRotateSpeed = -25.0f;
 	public float OrbitSpeed = 10.0f;

    void Start()
    {
    	this.coordinates = this.transform.position;

    	Renderer planetRenderer;
    	planetRenderer = GetComponent<Renderer>();
    	planetRenderer.material.color = new Color(Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),1);

    	List<GameObject> newMoons = new List<GameObject>();
    	int moonsQty = Random.Range(1, 6);

    	float planetSize =  Random.Range(0.1f, 0.9f);
        this.transform.localScale = new Vector3(planetSize, planetSize, planetSize);

        List<string> planetTypes = new List<string>(new string[] { "gas", "rock", "water", "ice", "earth", "vulcan", "superearth", "desert", "exotic" });
        int selectTypeIndex = Random.Range(0, planetTypes.Count);

        this.type = planetTypes[selectTypeIndex];
        this.habitableLevel = Random.Range(0, 6);
        this.civilizationLevel = Random.Range(0, 6);


        for(var i = 0; i < moonsQty; i++){
        	
        	var moon = Instantiate(Moon, new Vector3(this.coordinates.x, this.coordinates.y, this.coordinates.x + (i * 10)), Quaternion.identity);	
        	newMoons.Add(moon);
        }

        this.moons = newMoons;
    }

    void Update()
    {
   	// planet to spin on it's own axis
     transform.Rotate(transform.up * PlanetRotateSpeed * Time.deltaTime);
     
     // planet to travel along a path that rotates around the sun
     transform.RotateAround (Vector3.zero, Vector3.up, OrbitSpeed * Time.deltaTime);
    }
}









