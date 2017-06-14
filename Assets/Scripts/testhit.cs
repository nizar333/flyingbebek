using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testhit : MonoBehaviour {
	public Transform canvas;

	public void OnTriggerEnter(Collider other)
	{		
		if(other.gameObject.tag == "batang")
		Debug.Log("hit");
		gameObject.SetActive(false);
		canvas.gameObject.SetActive(true);
	}
}
