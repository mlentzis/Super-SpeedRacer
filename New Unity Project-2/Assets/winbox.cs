using UnityEngine;
using System.Collections;

public class winbox : MonoBehaviour {

	public void OnTriggerEnter(Collider other)
	{

		GameObject.Find("Car").SendMessage("end1");
	}


}
