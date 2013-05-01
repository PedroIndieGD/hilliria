using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	bool desenhar;
	
	public void FixedUpdate ()
	{
		
		if(Input.GetKeyDown(KeyCode.C))
		{
			Time.timeScale = 0;
			RenderSettings.fog = true;
			
		}
		
	}
	
	void OnGUI (){
		
	if(Time.timeScale == 0)
	{
		Screen.showCursor = true;	
					
		if(GUI.Button(new Rect(Screen.width/2- 250, Screen.height/2 - 50, 500, 100), "Resume"))
		{
			Time.timeScale =1;
			Screen.showCursor = false;	
			RenderSettings.fog = false;	
		}
		
		if(GUI.Button(new Rect(Screen.width/2 - 250, Screen.height/2 + 50, 500, 100), "Main Menu"))
		{
			Time.timeScale =1;
			Application.LoadLevel(1);
				
		}
	}
		
	}
}
