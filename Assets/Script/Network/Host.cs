using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Host : MonoBehaviour {

	public Button botao;

	// Use this for initialization
	void Start () {
		Button btn = botao.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	public void TaskOnClick(){
		Debug.Log ("You have clicked on the button!");
	}
}
