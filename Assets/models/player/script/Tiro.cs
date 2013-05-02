using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {
	
	GameObject mira;
	GameObject enemy;
	GameObject player;
	GameObject bomba;
	float destruir;
	
	// Use this for initialization
	void Start () 
	{
	  	mira = GameObject.FindGameObjectWithTag("mira");
		enemy = GameObject.FindGameObjectWithTag("enemy");
	  bomba = GameObject.FindGameObjectWithTag("bomba");
        player = GameObject.FindGameObjectWithTag("Player");		
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
	
	
	/*void OnTriggerEnter(Collider enemy) {
		
		Mira m_s = mira.GetComponent<Mira>();
		m_s.pontos += 20;
        Destroy(enemy.gameObject);
	    Destroy(this.gameObject);
		
    }*/
    void OnTriggerEnter(Collider TheCollider){

       if(TheCollider.gameObject.tag == "enemy")
       {
         Mira m_s = mira.GetComponent<Mira>();
			
		
			
         m_s.pontos += 20;
         Destroy(enemy.gameObject);
         Destroy(this.gameObject);
		
       }
       else if(TheCollider.gameObject.tag == "bomba")
       {
         Destroy(bomba.gameObject);
         Destroy(this.gameObject);
         Application.LoadLevel(14);
      }
  }


}
