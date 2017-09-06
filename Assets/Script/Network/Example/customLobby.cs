using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class customLobby : MonoBehaviour {
	public string connectionIP = "127.0.0.1";
	public int portNumber = 8632;
	private bool connected = false;

	private void OnDisconnectedFromServer(){
		connected = false;
	}

	private void OnConnectedToServer(){
		connected = true;
			
	}

	private void OnServerInitialized(){
		connected = true;
	
	}


	private void OnGUI(){
		connectionIP = GUILayout.TextField (connectionIP);
		int.TryParse(GUILayout.TextField (portNumber.ToString()), out portNumber);

		if (!connected) {
			if (GUILayout.Button ("Connect")) {
				Network.Connect (connectionIP, portNumber);
			}

			if (GUILayout.Button ("Host")) {
				Network.InitializeServer (4, portNumber);
			}
		} else { GUILayout.Label ("Connections: " + Network.connections.Length.ToString ());}
	}
}
