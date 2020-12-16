using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class coletarItens : MonoBehaviour {

	int N=0; //para pecorrer o vetor 

	public Text lblColetado0;
	public Text lblColetado1;
	public Text lblColetado2;
	public Text lblColetado3;
	public Text lblColetado4;
	public Text lblColetado5;
	public Text lblColetado6;


	string[] letras={"C","A","D","E","I","R","A"};
	int aux_letra = 0; //variável de identificação de letra

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.R)){
			transform.Translate (1, 2, 1);
		}
	}

	void OnTriggerEnter(Collider other){
		
		if (other.name == letras[N]){ //verifica se o nome do objeto "cubo de letra" é igual a letra na posição N
			GetComponent<AudioSource> ().Play (); //executar o som de coleta de letra
			other.gameObject.SetActive (false);
		
			if (letras [N] == "C")
				escreveLetrasC ();
			else if (letras [N] == "A" && aux_letra == 0){
				escreveLetrasA ();
				aux_letra = 1;
			}
			else if (letras [N] == "D")
				escreveLetrasD ();
			else if (letras [N] == "E")
				escreveLetrasE ();
			else if (letras [N] == "I")
				escreveLetrasI ();
			else if (letras [N] == "R")
				escreveLetrasR ();
			else if (letras [N] == "A")
				escreveLetrasA2 ();

			N++;

		}
		if (N == 7) { //pular de cena quando chegar no final do vetor
			SceneManager.LoadScene ("Cena_parabens");
		}
	}

	//funções para escrever nas caixas de texto as letras coletadas
	void escreveLetrasC(){
		lblColetado0.text = letras[N];
	}
	void escreveLetrasA(){
		lblColetado1.text = letras[N];
	}
	void escreveLetrasD(){
		lblColetado2.text = letras[N];
	}
	void escreveLetrasE(){
		lblColetado3.text = letras[N];
	}
	void escreveLetrasI(){
		lblColetado4.text = letras[N];
	}
	void escreveLetrasR(){
		lblColetado5.text = letras[N];
	}
	void escreveLetrasA2(){
		lblColetado6.text = letras [N];
	}
		
}