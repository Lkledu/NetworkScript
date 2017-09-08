using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class LobbyCustom : NetworkLobbyManager {

	private string ipAddress = "127.0.0.1";
	private int portNumber = 7787;

	public void HostStarter(){
		if (!NetworkClient.active && !NetworkServer.active) {
			SetPort ();
			NetworkManager.singleton.StartHost ();
			NetworkManager.singleton.ServerChangeScene ("lobby");
			Debug.Log ("Host Started");
		}
	}

	public void ClientStarter(){
		if (!NetworkClient.active && !NetworkServer.active) {
			SetIpAddress ();
			SetPort ();

			NetworkLobbyManager.singleton.StartClient ();
			NetworkManager.singleton.ServerChangeScene ("lobby");
			Debug.Log ("Client Started");
		}
	}

	public void Disconnect(){
		if (isNetworkActive) {
			NetworkManager.singleton.StopHost ();
			Debug.Log ("Host Stoped");

		}
	}

	private void SetIpAddress(){
		string ipAddress = "127.0.0.1";
		NetworkManager.singleton.networkAddress = ipAddress;
	}

	private void SetPort(){
		NetworkManager.singleton.networkPort = 7789;
	}

	private void OnLevelWasLoaded(int level){
		if(level == 0){
			SetupMenuSceneButtons();
			Debug.Log ("Level: "+ level);
		}else{
			SetupOtherSceneButtons();
			Debug.Log ("Level: "+ level);
		}
	}

	private void SetupMenuSceneButtons(){
		GameObject.Find("btnHost").GetComponent<Button>().onClick.RemoveAllListeners();
		GameObject.Find("btnHost").GetComponent<Button>().onClick.AddListener(HostStarter);

		GameObject.Find("btnJoin").GetComponent<Button>().onClick.RemoveAllListeners();
		GameObject.Find("btnJoin").GetComponent<Button>().onClick.AddListener(ClientStarter);
	}

	private void SetupOtherSceneButtons(){
		GameObject.Find("btnDisconnect").GetComponent<Button>().onClick.RemoveAllListeners();
		GameObject.Find("btnDisconnect").GetComponent<Button>().onClick.AddListener(Disconnect);
	}
}
