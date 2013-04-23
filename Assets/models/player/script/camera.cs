using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	
	GameObject mira;
	
	float rotacao;
	
	// Use this for initialization
	void Start () {
		rotacao = 0.001f;
		
		mira = GameObject.FindGameObjectWithTag("mira");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	  Mira m_s = mira.GetComponent<Mira>();
	  transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + m_s.velocidade);   
		
	}
}
