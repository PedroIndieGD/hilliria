using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
public class bomba : MonoBehaviour {
	
	public bool descer;
	public GameObject tiro;
	
	// Use this for initialization
	void Start () {
	
		descer = false;
		tiro = GameObject.FindGameObjectWithTag("tiro");
	}
	
	// Update is called once per frame
	void Update () {
	
		
		if(descer == true)
		{
		transform.position = new Vector3(transform.position.x , transform.position.y - 1 , transform.position.z);
		}
		
		if(transform.position.y <= -150)Application.LoadLevel(13);
	}
	void OnTriggerEnter(Collider tiro) 
	{
		Application.LoadLevel(13);
		
        Destroy(tiro.gameObject);
		
    }
}
