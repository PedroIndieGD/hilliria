using UnityEngine;
using System.Collections;

public class radius : MonoBehaviour {
	
	void OnTriggerEnter(Collider collision){
		if(collision.transform.tag =="Player"){
			SendMessageUpwards("CanShoot", true);
		}
	}
	void OnTriggerExit(Collider collision){
		if(collision.transform.tag =="Player"){
			SendMessageUpwards("CanShoot", false);
		}
	}
}
