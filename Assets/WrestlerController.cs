using UnityEngine;
using System.Collections;

public class WrestlerController : MonoBehaviour {
	float deltaX;
	float deltaY;

	Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>(); 
	}

	// Update is called once per frame
	void Update () {
		deltaX = Input.GetAxis("Horizontal");
		deltaY = Input.GetAxis("Vertical");

		rigidbody.AddForce(transform.forward * deltaY * 10f, ForceMode.Force);
		rigidbody.AddTorque(transform.up * deltaX * 1f);
	}
}
