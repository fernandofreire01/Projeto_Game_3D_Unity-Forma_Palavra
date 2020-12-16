using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tempoJogo : MonoBehaviour {

	public Text lblTempo;
	private float tempo = 60; //tempo em segundos
	private int tempoMinutos = 9; //tempo em minutos

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (tempoMinutos >= 0) {
			tempo -= Time.deltaTime;

			int tempoTexto = (int)tempo; //converte variável float em int

			if (tempoTexto >= 10)
				lblTempo.text = tempoMinutos + ":" + tempoTexto.ToString ();
			else
				lblTempo.text = tempoMinutos + ":0" + tempoTexto.ToString ();

			if (tempoTexto == 0) {
				tempoMinutos = tempoMinutos - 1;
				tempo = 60;
			}
		}
			
		if (tempoMinutos < 0) {
			SceneManager.LoadScene ("Cena_gameover");
		}

	}
}

