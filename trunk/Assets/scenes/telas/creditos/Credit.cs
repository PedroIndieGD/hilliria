using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI ()
	{
			
		if(GUI.Button(new Rect(Screen.width - 200 , Screen.height - 200 , 150, 150), "Skip"))
		{				
					
			Application.LoadLevel(1);
	     }
		
  }
}
