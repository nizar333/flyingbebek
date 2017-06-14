using UnityEngine;
using System.Collections;

public class wall : MonoBehaviour {

	public Vector3 spawnPoint;

	private Transform camPos;

	// Use this for initialization
	void Start () {
		int ranXPos = Random.Range(-5,6);
		transform.position = new Vector3(ranXPos, spawnPoint.y, spawnPoint.z);
		camPos = GameObject.Find ("Main Camera").GetComponent<Transform> ();	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += Vector3.back*0.5f;

		if(transform.position.z < camPos.position.z){
		
		}
	
	}
}
