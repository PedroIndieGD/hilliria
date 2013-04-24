using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
public class bomba : MonoBehaviour {
	
	public bool descer;
	GameObject mira, tiro;
	
	// Use this for initialization
	void Start () {
	
		descer = false;
		mira = GameObject.FindGameObjectWithTag("mira");
		tiro = GameObject.FindGameObjectWithTag("tiro");
	}
	
	// Update is called once per frame
	void Update () {
	
		Mira m_s = mira.GetComponent<Mira>();			
		
		if(descer == true)
		{
		transform.position = new Vector3(transform.position.x , transform.position.y - 1, transform.position.z);
		}
		
		if(transform.position.y <= -150)Application.LoadLevel(13);		
			transform.position = new Vector3(transform.position.x , transform.position.y  , m_s.transform.position.z);
	}
	
}
