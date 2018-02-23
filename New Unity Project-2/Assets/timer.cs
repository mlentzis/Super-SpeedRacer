using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class timer : MonoBehaviour {

	public Text timerText;
	public  float st;



	void Start ()
	{
		st = 10;


	}

	public void Update ()
	{


			float t = st - Time.time;
			string sec = t.ToString ("f0");

		  timerText.text = sec;

			if (t <= 0) {
				string k = "GO ";
				timerText.text = k;
				timerText.color = Color.green;

			} 

			if (t < -2) {

				string xw = " ";
				timerText.text = xw;
			}


		}




}
