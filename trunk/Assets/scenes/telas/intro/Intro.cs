using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {

	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(transform.position.x , transform.position.y -0.02f , transform.position.z);
		
		if(transform.position.y < -140)Application.LoadLevel(1);
	
	}
	
	void OnGUI ()
	{
			
		if(GUI.Button(new Rect(Screen.width - 200 , Screen.height - 200 , 150, 150), "Pular"))
		{				
					
			Application.LoadLevel(1);
	     }
		
  }
}