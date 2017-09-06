using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;

public class LobbyMatch : NetworkLobbyManager {

	void Start () {
		MMStart ();
		MMListMatches ();
	}

	void MMStart(){
		Debug.Log ("MMStart");

		this.StartMatchMaker ();
	}

	void MMListMatches (){
		Debug.Log ("MMListMatches");
		this.matchMaker.ListMatches (0,20,"",true,0,0,OnMatchList);
	}

	public override void OnMatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matchList){
		Debug.Log ("CALLBACK:: OnMatchList");
		base.OnMatchList (success, extendedInfo,matchList);

		if (!success) {
			Debug.Log ("List failed"+extendedInfo);
		}else{
			if (matchList.Count > 0) {
				Debug.Log ("Successfully list matches. 1st match: " + matchList[0]);
				MMJoinMatch (matchList[0]);
			} else {
				MMCreateMatch ();
			}
		}
	}

	void MMJoinMatch(MatchInfoSnapshot firstMatch){
		Debug.Log ("MMJoinMatch");

		this.matchMaker.JoinMatch (firstMatch.networkId, "", "", "",0,0, OnMatchJoined);
	}

	public void OnMatchJoined(bool success, string extendedInfo, List<MatchInfoSnapshot> matchList){
		Debug.Log ("CALLBACK:: OnMatchJoined");

		base.OnMatchJoined (success, extendedInfo, matchInfo);

		if (!success) {
			Debug.Log ("failed OnJoinMatch. match: " + extendedInfo);
		} else {
			Debug.Log ("successfully OnJoinMatch. match: "+matchInfo.networkId);
		}
	}

	void MMCreateMatch(){
		Debug.Log ("MMCreateMatch");

		this.matchMaker.CreateMatch ("MM", 15, true,"","","",0,0,OnMatchCreate);
	}

	public void OnMatchCreate(bool success, string extendedInfo, List<MatchInfoSnapshot> matchList){
		base.OnMatchCreate (success,extendedInfo,matchInfo);

		if (!success) {
			Debug.Log ("Failed OnMatchCreate. match: " + extendedInfo);
		} else {
			Debug.Log ("Successfully OnCreateMatch. match: " + matchInfo.networkId);
		}
	}
}
