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
	float  randomX,randomY;
	
	int SpawnTime = 0;
	int nextSpawnTime = 20;
	public bool InitializedExtreme = false;
	int WaveSize = 2;
	int wave = 0;
	int MaxEnemyOnScreen = 100;
	#endregion
	
	Vector3 direcao;

	GameObject mira;
	
	void Start () 
	{
		mira = GameObject.FindGameObjectWithTag("mira");
		radius = GameObject.FindGameObjectWithTag("Radius");
		list_shots = new List<GameObject>();
		list_enemy = new List<GameObject>();
		direcao = new Vector3(0,0,0);
		
	}
	
	// Update is called once per frame
	public void FixedUpdate ()
	{
		//SpawnTime++;
		
		if(!Paused)
		{
		
			
		Mira m_s = mira.GetComponent<Mira>();
				
		#region movimento
		     
		#region limitando posicao
		
		if(direcao.x > m_s.transform.position.x ) direcao.x = m_s.transform.position.x;
		if(direcao.x < m_s.transform.position.x )direcao.x = m_s.transform.position.x;
		if(direcao.y > m_s.transform.position.y +6)direcao.y = m_s.transform.position.y+6;
		if(direcao.y < m_s.transform.position.y +6)direcao.y = m_s.transform.position.y+6;
			 
       #endregion
		
        transform.position = new Vector3(direcao.x, direcao.y, transform.position.z + m_s.velocidade);   	

		transform.LookAt(mira.transform);	
		#endregion
			
		#region tiro
		
		posi_shots = new Vector3(transform.position.x, transform.position.y -5, transform.position.z +10 );
		
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(shot, posi_shots, Quaternion.identity );			
			list_shots.Add(shot);
		}
		
		#endregion
		nextSpawnTime--;	
		
			if(InitializedExtreme)
			{

				if(nextSpawnTime < SpawnTime)
				{
					wave = 0;
					WaveSize = 4;
					enemySpawn();
					nextSpawnTime = 5;				
				}
			}
			else
			{				
				if(nextSpawnTime < SpawnTime)
				{
					wave = 0;
					enemySpawn();
					nextSpawnTime = 100;
					
				}
			}
		
		}		
	}
	
	void enemySpawn()
	{
		//if(list_enemy.Count < MaxEnemyOnScreen)
		//{
			while(wave < WaveSize)
			{
				randomX = Random.Range(-30f,30f);
				randomY = Random.Range(-15f,20f);
		
				Instantiate(enemy, new Vector3(randomX, randomY, transform.position.z + 2000), Quaternion.identity);
				list_enemy.Add(enemy);
				wave++;
			}
		//}
	}		
}