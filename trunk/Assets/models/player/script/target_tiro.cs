using UnityEngine;
using System.Collections;

public class target_tiro : MonoBehaviour {

	GameObject mira;
	Vector3 direcao;
	
	// Use this for initialization
	void Start () {
	
		mira = GameObject.FindGameObjectWithTag("mira");
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		Mira m_s = mira.GetComponent<Mira>();
		direcao.x += Input.GetAxis("Mouse X") * 2;
		direcao.y += Input.GetAxis("Mouse Y") * 2;
         
		if(direcao.x > 59)direcao.x = 59;
		if(direcao.x < -59)direcao.x = -59;
		if(direcao.y > 28)direcao.y = 28;
		if(direcao.y < -28)direcao.y = -28; 
		
        transform.position = new Vector3(direcao.x, direcao.y, transform.position.z + m_s.velocidade);   						
		   
		
	}
}
