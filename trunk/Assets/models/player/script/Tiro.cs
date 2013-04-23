using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {
	
	GameObject mira;
	GameObject enemy;
	float destruir;
	
	// Use this for initialization
	void Start () 
	{
	  	mira = GameObject.FindGameObjectWithTag("mira");
		enemy = GameObject.FindGameObjectWithTag("enemy");	
	  	transform.LookAt(mira.transform);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Mira m_s = mira.GetComponent<Mira>();
								
		destruir += Time.deltaTime;
		
		if(destruir >= 5) Destroy(this.gameObject);
		
	   	transform.Translate(Vector3.forward * 7 );		
				
	}
	
	void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
	
	
	void OnTriggerEnter(Collider enemy) {
		
		Mira m_s = mira.GetComponent<Mira>();
		m_s.pontos += 20;
        Destroy(enemy.gameObject);
		
    }
}
