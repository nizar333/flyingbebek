using UnityEngine;
using System.Collections;

public class pinggiran : MonoBehaviour {
public Vector3 spawnPoint;

	private Transform camPos;
	// Use this for initialization
	void Start () {

		transform.position = new Vector3(7, spawnPoint.y, spawnPoint.z);
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += Vector3.back*0.5f;
	
	}
}
