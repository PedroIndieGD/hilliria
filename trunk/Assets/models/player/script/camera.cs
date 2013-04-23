using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	
	GameObject mira;
	int contador;
	
	// Use this for initialization
	void Start () {
		
		mira = GameObject.FindGameObjectWithTag("mira");
		transform.rotation = new Quaternion(transform.rotation.x , transform.rotation.y , 0 , transform.rotation.w);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	  Mira m_s = mira.GetComponent<Mira>();
	  transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + m_s.velocidade);   
		
		if(m_s.rota == true)
		{
		if(transform.rotation.z != 0.01f && transform.rotation.z != -0.01f  )transform.rotation = new Quaternion(transform.rotation.x , transform.rotation.y , 0.01f , transform.rotation.w);	
			
		transform.rotation = new Quaternion(transform.rotation.x , transform.rotation.y , transform.rotation.z * -1 , transform.rotation.w);
			contador ++;
	    }
		if(contador >= 30)
		{
			m_s.rota = false;
			transform.rotation = new Quaternion(transform.rotation.x , transform.rotation.y , 0 , transform.rotation.w);	
		}
		
	}
}
