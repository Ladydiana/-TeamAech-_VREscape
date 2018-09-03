using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSlideUpExit : MonoBehaviour {

	private Transform endPosition;

	void Start() {
		endPosition = new GameObject().transform;
		endPosition.position = new Vector3(	transform.position.x, 
											(float)(transform.position.y + 2),//transform.localScale.y * 2.3),
											transform.position.z );

	}

	
	void Update() {
		if((transform.position.y < endPosition.position.y) && GameController.isGameOver) {
			Debug.Log("Game over!");
			transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		}
	}
}
