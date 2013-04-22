using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class Player : MonoBehaviour {
	
	#region tiro
	Vector3 posi_shots;
	public GameObject shot, enemy, radius;
	protected bool Paused;
	public List<GameObject> list_shots;
	public List<GameObject> list_enemy;
	int spawnTimer;
	float  randomX,randomY;

	#endregion
	
	Vector3 direcao;

	GameObject mira;
	
	void Start () 
	{
		mira = GameObject.FindGameObjectWithTag("mira");
		radius = GameObject.FindGameObjectWithTag("Radius");
		list_shots = new List<GameObject>();
		list_enemy = new List<GameObject>();
		
	}
	
	// Update is called once per frame
	public void FixedUpdate ()
	{
		spawnTimer++;
		
		if(!Paused)
		{
			
		Mira m_s = mira.GetComponent<Mira>();
				
		#region movimento
		     
		#region limitando posicao
		
		if(direcao.x > m_s.transform.position.x +1) direcao.x -= 0.7f;
		if(direcao.x < m_s.transform.position.x -1)direcao.x += 0.7f;
		if(direcao.y > m_s.transform.position.y +1)direcao.y -= 0.7f;
		if(direcao.y < m_s.transform.position.y -1)direcao.y += 0.7f;

       #endregion
		
        transform.position = new Vector3(direcao.x, direcao.y, transform.position.z + m_s.velocidade);   	

		transform.LookAt(mira.transform);	
		#endregion
			
		#region tiro
		
		posi_shots = new Vector3(transform.position.x, transform.position.y, transform.position.z + 30 );
		
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(shot, posi_shots, Quaternion.identity );			
			list_shots.Add(shot);
		}
		
		#endregion
			
		if(spawnTimer > 300)
			{
				enemySpawn();
				spawnTimer = 0;
			}
		
		}		
	}
	
	void enemySpawn()
	{
		if(list_enemy.Count < 10)
		{
			randomX = Random.Range(-15f,20f);
			randomY = Random.Range(-15f,20f);
		
			Instantiate(enemy, new Vector3(randomX, randomY, transform.position.z + 2000), Quaternion.identity);
			list_enemy.Add(enemy);
		}
	}
	
	void OnTriggerEnter(Collider radius){
		
		
	}
		
}