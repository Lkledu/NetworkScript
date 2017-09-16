using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class BroadCast : NetworkBehaviour {
	private int hostID;
	private int castPort;
	private int key = 3;
	private int ver = 1;
	private int subver = 1;
	private byte[] bufferByte;
	private int sizeByte;
	private int timeout = 1;

	public void sendBroadcast(){
		byte error;
		//NetworkTransport.ReceiveFromHost (hostID,);
		NetworkTransport.StartBroadcastDiscovery (NetworkServer.serverHostId, NetworkManager.singleton.networkPort, key, ver, subver,bufferByte,sizeByte,timeout,out error);
		Debug.Log ("StartBroadcast Success");
	}

	public void receiveBroadcast(){
		
	}

	public void stopBroadcast(){
		NetworkTransport.StopBroadcastDiscovery ();
	}

}
