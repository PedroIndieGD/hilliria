using UnityEngine;
using System.Collections;

public class instrucoes : MonoBehaviour {

	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI ()
	{
			
		if(GUI.Button(new Rect(Screen.width - 200 , Screen.height - 200 , 150, 150), "Jogar"))
		{				
					
			Application.LoadLevel(5);
	     }
		
  }
}
