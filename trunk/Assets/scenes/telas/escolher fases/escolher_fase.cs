using UnityEngine;
using System.Collections;

public class escolher_fase : MonoBehaviour {

	void OnGUI (){
	
		if(transform.position.z > -400)
		{
		if(GUI.Button(new Rect(Screen.width/2 + 500, Screen.height/2 , 100, 90), "next")){
			
			if(transform.position.z > -400)transform.position = new Vector3(transform.position.x , transform.position.y , transform.position.z - 50);
		}
		}
		if(transform.position.z < 0)
		{
		if(GUI.Button(new Rect(Screen.width/2 - 550, Screen.height/2 , 100, 90), "previous")){
			
			if(transform.position.z < 0)transform.position = new Vector3(transform.position.x , transform.position.y , transform.position.z + 50);
		}
		}
		if(GUI.Button(new Rect(Screen.width/2 - 250, Screen.height/2 + 250, 500, 100), "select"))
		{
			#region escolher a fase que ira jogar
			if(transform.position.z == 0)Application.LoadLevel(5);
			if(transform.position.z == -50)Application.LoadLevel(5);
			if(transform.position.z == -100)Application.LoadLevel(5);
			if(transform.position.z == -150)Application.LoadLevel(5);
			if(transform.position.z == -200)Application.LoadLevel(5);
			if(transform.position.z == -250)Application.LoadLevel(5);
			if(transform.position.z == -300)Application.LoadLevel(5);
			if(transform.position.z == -350)Application.LoadLevel(5);
			if(transform.position.z == -400)Application.LoadLevel(5);
			#endregion
					
			
			Screen.showCursor = false;	
		}
	}
}
