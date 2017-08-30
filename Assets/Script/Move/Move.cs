using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public VirtualJoystick joystick;
	private GameObject player;

	// Update is called once per frame
	void Update () {
		if(joystick.inputVector.x != 0 && joystick.inputVector.x > 0){
			transform.RotateAround (Vector3.zero, Vector3.up, inputVector.x *(50 * Time.deltaTime));
		}

		if(joystick.inputVector.x != 0 && joystick.inputVector.x < 0){
			transform.RotateAround (Vector3.zero, Vector3.up, inputVector.x *(50 * Time.deltaTime));
		}

		if(joystick.inputVector.z != 0){
			Debug.Log ("UP: "+joystick.inputVector.z);
		}

			/*
			if (Input.touchCount > 0) {
				Touch toque = Input.GetTouch (0);
				Debug.Log (toque.position.x);


			if(toque.position.x > (Screen.width/2))
				transform.RotateAround (Vector3.zero, Vector3.up, Time.deltaTime * -20);
			if(toque.position.x < (Screen.width/2))
				transform.RotateAround (Vector3.zero, Vector3.up, Time.deltaTime * 20);
		}
		*/

	}		
}