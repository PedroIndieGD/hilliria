using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void OnGUI (){
		
		if(GUI.Button(new Rect(Screen.width/2 - 250, Screen.height/2 -50, 500, 100), "Start")){
			
			Application.LoadLevel(3);
			
		}
		
		if(GUI.Button(new Rect(Screen.width/2 - 250, Screen.height/2 + 50, 500, 100), "Credits")){
			Application.LoadLevel (2);
		}
		
		if(GUI.Button(new Rect(Screen.width/2 -250, Screen.height/2 + 150, 500, 100), "Exit")){
			Application.Quit();
		}
	}
	
}
