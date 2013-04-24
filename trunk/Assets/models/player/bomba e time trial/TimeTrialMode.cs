using UnityEngine;
using System.Collections;

public class TimeTrialMode : MonoBehaviour {
	
	private float initialTime;
	
	private float regressiveCounter;
	
	private int amountTime;
	
	private float showTime;
	
	private float timeToExplosion;	
	
	public GameObject bomba;
	
	
	// Use this for initialization
	void Start () {
		
		regressiveCounter = 0;
		amountTime = 180 ;
		initialTime = Time.time;
		bomba = GameObject.FindGameObjectWithTag("bomba");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		regressiveCounter = Time.time - initialTime;
		showTime = amountTime - regressiveCounter;
		timeToExplosion = 5 - regressiveCounter;
			
		bomba m_s = bomba.GetComponent<bomba>();
		
		
		if(showTime <= 15){ 
		
			//Instantiate(explosion,new Vector3 (0,0, 200), this.transform.rotation);
			//Application.LoadLevel(13);
			
			m_s.descer=true;
			
		}
	}
	
	void OnGUI()
	{
		if  (showTime > 0){
			
			GUI.Label(new Rect(100, 150, 1000, 100) , "Time: " + showTime);
		
		}
	}

}

