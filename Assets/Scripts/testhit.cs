using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testhit : MonoBehaviour {
	public Transform canvas;

	public void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.tag == "batang") {
			Debug.Log ("batang");
			gameObject.SetActive (true);
			canvas.gameObject.SetActive (true);
		}
	}
}
