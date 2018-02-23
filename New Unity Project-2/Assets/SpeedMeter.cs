using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpeedMeter : MonoBehaviour {

	public Rigidbody objectToMeasure;
	public float maxVelocity = 10.0f;

	public bool disallowBackwards = false;

	private Image image;

	void Start ()
	{
		image = GetComponent<Image> ();

	}

	void Update ()
	{
		image.fillAmount = objectToMeasure.velocity.magnitude / maxVelocity;
	}


}
