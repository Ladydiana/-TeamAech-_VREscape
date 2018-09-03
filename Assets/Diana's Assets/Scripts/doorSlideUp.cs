using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSlideUp : MonoBehaviour {

	private bool isOpen;
	private Transform endPosition;
	
	void Start() {
		isOpen = false;
		endPosition = new GameObject().transform;
		endPosition.position = new Vector3(	transform.position.x, 
											(float)(transform.position.y + 2),//transform.localScale.y * 2.3),
											transform.position.z );

	}

	
	void Update() {
		if( (transform.position == endPosition.position) 
			&& isOpen) {
			Debug.Log("Disabled isOpen.");
			isOpen = false;
		}
		else if((transform.position.y < endPosition.position.y) && isOpen) {
			//Debug.Log("Going up up up");
			//Debug.Log(transform.position);
			//Debug.Log(endPosition.position);
			transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		}
	}
	
	
	public void Click() {
		if(transform.position != endPosition.position) {
			isOpen = true;
		}
	}
}
