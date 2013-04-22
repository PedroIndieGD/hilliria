using UnityEngine;
using System.Collections;

public class Mira : MonoBehaviour {
	
	public Vector3 direcao;
	public float velocidade;
	
	public int vida;
	public int energia;
	
	GameObject mira;
	
	public bool boost;
	public bool brake;
	
	public float pontos;
	
	// Use this for initialization
	void Start () {

		velocidade = 2;
		boost = false;
		brake = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		
		#region regulando velocidade
		if(energia >=5)
		{
			if(Input.GetKeyDown(KeyCode.W)) boost = true;
			if(Input.GetKeyDown(KeyCode.S)) brake = true;
		}
		if(Input.GetKeyUp(KeyCode.W)) boost = false;
		if(Input.GetKeyUp(KeyCode.S)) brake = false;
		if(boost == true)
		{
			 velocidade =5;
			 energia--;		
		}
		if(brake == true)
		{
			velocidade = 1;
			energia--;			
		}
		if(brake == false && boost ==false)velocidade=2;
			
		#endregion
	
		direcao.x += Input.GetAxis("Mouse X") * 2;
		direcao.y += Input.GetAxis("Mouse Y") * 2;
         
		if(direcao.x > 59)direcao.x = 59;
		if(direcao.x < -59)direcao.x = -59;
		if(direcao.y > 28)direcao.y = 28;
		if(direcao.y < -28)direcao.y = -28; 
		
        transform.position = new Vector3(direcao.x, direcao.y, transform.position.z + velocidade);   						
		 
	}

}
