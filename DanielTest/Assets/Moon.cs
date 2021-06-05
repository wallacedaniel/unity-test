using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{

	public Vector3 coordinates; 
	public Vector3 planetCoordinates;
	public string type;
	public int habitableLevel;
	public int civilizationLevel;


    void Start()
    {

    	this.coordinates = this.transform.position;
    	float moonSize =  Random.Range(0.02f, 0.09f);
        this.transform.localScale = new Vector3(moonSize, moonSize, moonSize);

    	Renderer moonRenderer;
    	moonRenderer = GetComponent<Renderer>();
    	moonRenderer.material.color = new Color(Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f),1);

    	List<string> moonTypes = new List<string>(new string[] { "gas", "rock", "water", "ice", "earth", "vulcan", "superearth", "desert", "exotic" });
        int selectTypeIndex = Random.Range(0, moonTypes.Count);

        this.type = moonTypes[selectTypeIndex];
        this.habitableLevel = Random.Range(0, 6);
        this.civilizationLevel = Random.Range(0, 6);
    }

    void Update()
    {
    	// orbit the planet and rotate on its axis   
    }
}
