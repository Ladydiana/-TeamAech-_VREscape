using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static bool isGameOver = false;

	private GameObject[] disabledWaypoints1, disabledWaypoints2, disabledWaypoints3, disabledWaypointsExit;

	
	// easier to do a function for this since we are calling it for multiple game objects
	void deactivateDisabledWaypoints(GameObject[] waypoints) {
		if(waypoints!=null) {
			foreach(GameObject w in waypoints) {
				w.SetActive(false);
			}
		}
	}
	
	void activateDisabledWaypoints(GameObject[] waypoints) {
		if(waypoints!=null) {
			foreach(GameObject w in waypoints) {
				w.SetActive(true);
			}
		}
	}
	
	// Use this for initialization
	void Start () {
		disabledWaypoints1 = GameObject.FindGameObjectsWithTag("DisabledWaypoint");
		disabledWaypoints2 = GameObject.FindGameObjectsWithTag("DisabledWaypoint2");
		disabledWaypoints3 = GameObject.FindGameObjectsWithTag("DisabledWaypoint3");
		disabledWaypointsExit = GameObject.FindGameObjectsWithTag("Disabled_Waypoint_Exit");
		
		
		//deactivating some waypoints to avoid clipping into areas we have no access yet
		//the corresponding waypoints should be activated when trap/switch has been pressed to give access to area
		deactivateDisabledWaypoints(disabledWaypoints1);
		deactivateDisabledWaypoints(disabledWaypoints2);
		deactivateDisabledWaypoints(disabledWaypoints3);
		deactivateDisabledWaypoints(disabledWaypointsExit);
	}
	
	// Update is called once per frame
	void Update () {
		if(isGameOver) {
			activateDisabledWaypoints(disabledWaypointsExit);
		}
	}
}
