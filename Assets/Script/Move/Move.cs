using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public VirtualJoystick joystick;
	private GameObject player;

	// Update is called once per frame
	void Update () {
		if(joystick.inputVector.x > 0){
			transform.RotateAround (Vector3.zero, Vector3.up, joystick.inputVector.x * (-50) * Time.deltaTime);
			Debug.Log ("X: "+joystick.inputVector.x);
			Debug.Log ("Time: "+Time.deltaTime);
		}

		if( joystick.inputVector.x < 0){
			transform.RotateAround (Vector3.zero, Vector3.down,joystick.inputVector.x * 50 * Time.deltaTime);
			Debug.Log ("X: " + joystick.inputVector.x);
		}

		if(joystick.inputVector.z > 0){
			transform.Translate (0, (10 * Time.deltaTime),0);
			Debug.Log ("UP: "+joystick.inputVector.z);
		}

		if(joystick.inputVector.z < 0){
			transform.Translate (0, (-10 * Time.deltaTime),0);
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