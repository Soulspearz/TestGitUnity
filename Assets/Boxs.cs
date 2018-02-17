using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxs : MonoBehaviour {
	float rotationx;
	float rotationy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rotationx += Time.deltaTime * 100;
		rotationy += Time.deltaTime * 100;
		transform.rotation = Quaternion.Euler (rotationx, rotationy, 0);

		
	}
}
