using UnityEngine;
using System.Collections;

public class enemyShot : MonoBehaviour {

	GameObject Target;
	GameObject mira;
	int vida;
	// Use this for initialization
	void Start () {
		
		Target = GameObject.FindGameObjectWithTag("Player");
		mira = GameObject.FindGameObjectWithTag("mira");
		transform.LookAt(Target.transform);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
			
	   	transform.Translate(Vector3.forward * 4 );		
		
	}
	
	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
	
	void OnTriggerEnter(Collider Target){
		
		Mira m_s = mira.GetComponent<Mira>();
		m_s.vida -=10;
		Destroy(this.gameObject);
		//Application.LoadLevel(13);
		
	}
}
