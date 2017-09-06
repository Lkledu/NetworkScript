using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Networking;

public class buttonListener : MonoBehaviour{

	//private NetworkLobbyManager host;
	private Button btn;


	void Start () {
		btn= GetComponent<Button> ();
		//host = GetComponent<NetworkLobbyHost>();
		btn.onClick.AddListener (TaskOnClick);
	}

	public void TaskOnClick(){
		//host.StartHost ();
		Debug.Log ("Button Clicked");
	
	}
}
