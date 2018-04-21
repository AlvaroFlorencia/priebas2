using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Vehicles.Car;

public class checkan : MonoBehaviour {
	public Text texto;
	public Text answer;
	//int score1;
    string[] questions = { "¿2+2?", "¿3+3?", "¿4+4?" };
    string[] answers = { "4", "6", "8" };
    int aleatorio;
	public GameObject Controls;
	public GameObject q;
	public InputField a;
	public GameObject panel;
	public GameObject particle1;
	public GameObject car;
    public CarCtrl carCtrl;
    public bool isOnQuestion = true;
	public score score;
	public int plus=1;

	// Use this for initialization
	void Start () {
        aleatorio = Random.Range(0, questions.Length - 1);
        texto.text = questions[aleatorio];
        carCtrl = FindObjectOfType<CarCtrl>();
    }
	
	// Update is called once per frame
	void Update () {
        if (answers[aleatorio] == answer.text)
        {
            InputField field = a;
            field.text = "";
            if (carCtrl)
            {
                print("Correcto");
                score.gainPoints();
                Controls.SetActive(true);
                q.SetActive(false);
                a.gameObject.SetActive(false);
                panel.SetActive(false);
                carCtrl.enableControls();
                particle1.SetActive(false);
            }
            else
            {
                score.gainPoints();
                carCtrl = FindObjectOfType<CarCtrl>();
                Controls.SetActive(true);
                q.SetActive(false);
                a.gameObject.SetActive(false);
                panel.SetActive(false);
                carCtrl.enableControls();
                particle1.SetActive(false);
                
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            carCtrl.disableControls();
            Controls.SetActive(false);
            q.SetActive(true);
            a.gameObject.SetActive(true);
            panel.SetActive(true);          
        }
       
    }

}
