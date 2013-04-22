using UnityEngine;
using System.Collections;

public class Terrain : MonoBehaviour {
	
	GameObject mira;
	
	// Use this for initialization
	void Start () {
	
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		mira = GameObject.FindGameObjectWithTag("mira");
		
		if(mira.transform.position.z > transform.position.z + 2100)transform.position = new Vector3(transform.position.x,transform.position.y, transform.position.z + 4000);
	}
}



