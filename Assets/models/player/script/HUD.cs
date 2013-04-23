using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	
	public Texture2D image;

	Rect vida;
	Rect energia;
	
	GameObject mira;
		
	int ganhar_energia;
	
	// Use this for initialization
	void Start ()
	{
	   mira = GameObject.FindGameObjectWithTag("mira");	
	   Mira m_s = mira.GetComponent<Mira>();
		
		m_s.vida = 100;
		m_s.energia = 100;
				
		vida = new Rect( Screen.width/2 -100, Screen.height/2 , 20, -m_s.vida *2);
		energia = new Rect( Screen.width/2 + 100 , Screen.height/2  ,20, -m_s.energia*2);
		
		
	}
	void FixedUpdate () 
	{
		Mira m_s = mira.GetComponent<Mira>();
		
		
		#region regulando vida e nergia
		
		ganhar_energia++;
		
		if(m_s.vida >= 105) m_s.vida = 105;
		if(m_s.energia >= 105) m_s.energia = 105;
		if(m_s.vida <= 0) Application.LoadLevel(13);
		if(m_s.energia < 0) m_s.energia = 0;
		
		if(m_s.boost == false && m_s.brake == false)
		{
		if(ganhar_energia >= 30 && m_s.energia < 105) 
		{
		     m_s.energia +=5;
			ganhar_energia =0;
		}
		}
		#endregion
		
		#region posição das barras
		vida = new Rect( Screen.width - 250 , Screen.height -50 , 30, -m_s.vida *2);
		energia = new Rect( Screen.width -150, Screen.height -50 ,30, -m_s.energia*2);

		#endregion
	}

	void OnGUI()
	{
		
		Mira m_s = mira.GetComponent<Mira>();
		
		GUI.Label(new Rect(100,100,1000,100) , "Pontos: " + m_s.pontos.ToString());
		
		GUI.DrawTexture(vida , image);
		GUI.DrawTexture(energia ,image);
		
	}
}
