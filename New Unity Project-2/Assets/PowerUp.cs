using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	public float rotateSpeed = 45;
	public float pulseSpeed = 10;

	void Update() {

		Vector3 tempRot = transform.rotation.eulerAngles;
		tempRot.y += rotateSpeed * Time.deltaTime;
		transform.eulerAngles = tempRot;
	}

	void OnTriggerEnter(Collider other)
	{
		other.GetComponent<Rigidbody>().AddForce (pulseSpeed * other.transform.forward, ForceMode.Impulse);
		Destroy (gameObject);
	}
}

