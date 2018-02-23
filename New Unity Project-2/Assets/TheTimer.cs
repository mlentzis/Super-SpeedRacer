using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TheTimer : MonoBehaviour {

	public Text timerText;
	public  float st;
	public bool end = false; 


	void Start ()
	{
		st = 10;


	}

	void Update () {

		if (end) {

			return;
		}

	
			float t = Time.time - st;

			string min = ((int)t / 60).ToString ();
			string sec = (t % 60).ToString ("f1");

			timerText.text = "Score: " + min + ":" + sec;


	}

	void end1()
	{
		end = true;
		timerText.color = Color.green;

	}













}