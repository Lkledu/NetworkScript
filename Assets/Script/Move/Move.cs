using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public VirtualJoystick joystick;


	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0) {
			Touch toque = Input.GetTouch (0);
			Debug.Log (toque.position.x);


			joystick.Around ();
			/*
			if(toque.position.x > (Screen.width/2))
				transform.RotateAround (Vector3.zero, Vector3.up, Time.deltaTime * -20);
			if(toque.position.x < (Screen.width/2))
				transform.RotateAround (Vector3.zero, Vector3.up, Time.deltaTime * 20);
		*/
		}
	}		
}