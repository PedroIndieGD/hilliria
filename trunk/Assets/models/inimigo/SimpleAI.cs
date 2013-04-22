using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SimpleAI : MonoBehaviour {
	
	private bool collidingPlayer;
	
	private Transform Player;
	public GameObject enemyShot;
	private Vector3 posiShot;
	public float Velocidade, DistanceToPlayer, AngleToPlayer;
	private List<GameObject> enemyShots;
	float shotDelay;
	bool canShoot;
	GameObject mira;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player").transform;
		mira = GameObject.FindGameObjectWithTag("mira");
		
		enemyShots = new List<GameObject>();
		
		Velocidade = 15;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		shotDelay ++;
		
		DistanceToPlayer = Vector3.Distance(transform.position, Player.position);
		
		AngleToPlayer = Vector3.Angle(transform.position, Player.position);
		
		DistanceControler();

	}
	
	void DistanceControler()
	{
		if (DistanceToPlayer < 1500 && DistanceToPlayer > 0)
		{
			
			FollowPlayer(true);
		} 
		else
		{
			
			FollowPlayer(false);
		
		}
		
		if (DistanceToPlayer <= 800 && shotDelay > 100)
		{
			shootPlayer(true);
			shotDelay = 0;
			
		}
		else{
			shootPlayer(false);
		}
		
		if (DistanceToPlayer <= 500)
		{
			
			kamikazeAttack(true);
			
		}
		else{
			kamikazeAttack(false);
		}
	
	}
	
	void FollowPlayer(bool follow)
	{
		
		if (follow)
		{			
			Vector3 Direction = (Player.position - transform.position).normalized;
			Quaternion LookAt = Quaternion.LookRotation(Direction);
			if(!collidingPlayer)
				transform.rotation =  LookAt;
			if(this.transform.position.x < Player.position.x + 10 ){
				
				//this.transform.position.x = new Vector3(Player.position.x,this.transform.position.y,this.transform.position.z);
				this.transform.position += new Vector3(0.4f,0,0);
			}
			else if(this.transform.position.x > Player.position.x - 10){
				this.transform.position -= new Vector3(0.4f,0,0);
				
			}
			
			if(this.transform.position.y < Player.position.y + 10 ){
				
				//this.transform.position.x = new Vector3(Player.position.x,this.transform.position.y,this.transform.position.z);
				this.transform.position += new Vector3(0,0.4f,0);
			}
			else if(this.transform.position.x > Player.position.y - 10){
				this.transform.position -= new Vector3(0,0.4f,0);
				
			}
		
			transform.Translate(Vector3.forward * 3 );
			
		}
		else
		{
			return;
		}
	}
	
	public void shootPlayer(bool _shot)
	{
		if(_shot)
		{
			posiShot = new Vector3(transform.position.x, transform.position.y - 1.5f , transform.position.z - 30);
			Instantiate(enemyShot, posiShot, Quaternion.identity);			
			enemyShots.Add(enemyShot);
		}
		else
		{
			return;
		}
	}
	
	void kamikazeAttack(bool kamikaze){
		
		if(kamikaze)
		{
			
		}
		else
		{
			return;
		}
		
	}
	void CanShoot(bool Value){canShoot=Value;}
	void OnBecameInvisible(){
		
		Destroy(this.gameObject);
		
	}
	void OnTriggerEnter(Collider Player){
		
		Mira m_s = mira.GetComponent<Mira>();
		//m_s.vida -=10;
		Destroy(this.gameObject);
		//Application.LoadLevel(13);
		
	}
}
