using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarCtrl : MonoBehaviour {

	public GameObject CtrlCar;
	//public score sc; //score
	//private LevelManager levelManager;
	void Start () {



		
	}
	//public void subirScore() //the score is increased
	//{
		//sc.gainPoints ();
		//levelManager.score++; //Score++
	//}


	
	// Update is called once per frame
	void Update () {
		CtrlCar.GetComponent<CarController>().enabled = true;
		//levelManager = FindObjectOfType<LevelManager>(); 
		//sc = FindObjectOfType<score> ();

	}
}
