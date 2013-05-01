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
	
	public bool rota;
	
	// Use this for initialization
	void Start () {

		velocidade = 2;
		boost = false;
		brake = false;
		
		direcao = new Vector3(0,-6,150);

	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		
		#region regulando velocidade
		if(energia >= 5)
		{
			if(Input.GetKeyDown(KeyCode.W)) boost = true;
			if(Input.GetKeyDown(KeyCode.S)) brake = true;
		}
		else if( energia <=0)
		{
			boost = false;
			brake = false;
		}
		if(Input.GetKeyUp(KeyCode.W)) boost = false;
		if(Input.GetKeyUp(KeyCode.S)) brake = false;
		if(boost == true)
		{
			 velocidade = 5;
			 energia--;		
		}
		if(brake == true)
		{
			velocidade = 1;
			energia--;			
		}
		if(brake == false && boost ==false)velocidade=2;
			
		#endregion
	
		direcao.x += Input.GetAxis("Mouse X") * 5;
		direcao.y += Input.GetAxis("Mouse Y") * 5;
         
		if(direcao.x > 150)direcao.x = 150;
		if(direcao.x < -150)direcao.x = -150;
		if(direcao.y > 100)direcao.y = 100;
		if(direcao.y < -20)direcao.y = -20; 
		
        transform.position = new Vector3(direcao.x, direcao.y, transform.position.z + velocidade);   						
		 
	}

}
