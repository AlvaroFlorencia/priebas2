using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Vehicles.Car;

public class checkan : MonoBehaviour {
	public Text texto;
	public Text answer;
	public Text score;
	//int score1;
	string questions="¿2+2?,4,¿3+3?,6,¿4+4?,8";
	string[] array;
	int aleatorio;
	public GameObject Controls;
	public GameObject q;
	public GameObject a;
	public GameObject panel;
	public GameObject particle1;
	//public GameObject car;
	//score points;
	//public int plus=1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(array[aleatorio+1]==answer.text){
			
			print("correcto");
			Controls.SetActive (true);
			q.SetActive (false);
			a.SetActive (false);
			panel.SetActive (false);
			particle1.SetActive (false);
		}else{
			print("incorrecto");
		}
	}
	void OnTriggerEnter () {
		//car.GetComponent<CarCtrl>().subirScore();
		print("tocandome");
		Controls.SetActive (false);
	
		q.SetActive (true);
		a.SetActive (true);
		panel.SetActive (true);
	

	array = questions.Split (',');
	 aleatorio = Random.Range(0,array.Length-1);
		if (aleatorio % 2 == 0) {
		} else {
			if (aleatorio == array.Length) {
				aleatorio--;
			} else {
				aleatorio++;
			}
		}


		texto.text = array [aleatorio];
		print (aleatorio);
		print(array [aleatorio]);
		print(array [aleatorio+1]);

	}

}
