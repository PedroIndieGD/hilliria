using UnityEngine;
using System.Collections;

public class game_over : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.showCursor = true;	
	
	}
	
	// Update is called once per frame
	void OnGUI ()
	{
			
		if(GUI.Button(new Rect(Screen.width - 200 , Screen.height - 200 , 150, 150), "Menu"))
		{				
					
			Application.LoadLevel(1);
	     }
			
		if(GUI.Button(new Rect( 0 + 50, Screen.height - 200 , 150, 150), "Exit"))
		{				
					
		  Application.Quit();
	     }
		
  }
}
