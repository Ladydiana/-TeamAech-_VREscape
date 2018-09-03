using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableClippingOnAnotherWaypoint : MonoBehaviour {

	public GameObject waypointToAvoidClipped = null;
	
	private GameObject player;
	
	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
		
		if(player == null)
			Debug.Log("ERROR! No GameObject with Player tag detected!");
		//else
		//	Debug.Log("Initialized player");
	}
	
	// Update is called once per frame
	void Update () {
		
		//Debug.Log(player.transform.position);
		
		//if(Camera.main.transform.parent.transform.position == gameObject.transform.position) {
		if(player.transform.position.x == transform.position.x && player.transform.position.z == transform.position.z) {
			//Debug.Log("We're here");
			if(waypointToAvoidClipped!=null) {
				waypointToAvoidClipped.SetActive(false);
			}
		}
		
		else if(waypointToAvoidClipped!=null && !waypointToAvoidClipped.activeSelf){
			//Debug.Log("Tralala");
			waypointToAvoidClipped.SetActive(true);
		}
		
	}
}
