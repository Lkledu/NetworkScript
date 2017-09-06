using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VoltarMenu : MonoBehaviour {

	private Button btnVoltar;
	// Use this for initialization
	void Start () {
		btnVoltar = GetComponent<Button> ();
		btnVoltar.onClick.AddListener (voltar);
	}

	private void voltar (){
		SceneManager.LoadScene ("menu");
	}

}
