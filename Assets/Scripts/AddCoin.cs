using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCoin : MonoBehaviour {

	// Use this for initialization
	public void OnTriggerEnter(Collider other)
	{		
		if(other.gameObject.tag == "coin")
			Debug.Log("coin");
	}
}
