using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {

	public Vector3 spawnPoint;

	private Transform camPos;
	// Use this for initialization
	void Start () {
		int ranXPos = Random.Range(-5,5);
		int ranYPos = Random.Range(2,5);
		transform.position = new Vector3(ranXPos, ranYPos, spawnPoint.z);
		camPos = GameObject.Find ("Main Camera").GetComponent<Transform> ();	
	}

	// Update is called once per frame
	void Update () {

		transform.position += Vector3.back*0.5f;

		if(transform.position.z < camPos.position.z){

		}

	}
}
