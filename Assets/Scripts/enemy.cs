using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

	public int spawnTime;

	private int timer;

	// Use this for initialization
	void Start () {

		batang();
	}

	// Update is called once per frame
	void Update () {

		timer++;

		if(timer >= spawnTime){

			batang();
			timer = 0;
		}

	}

	void batang(){

		Instantiate (Resources.Load ("enemy"));
	}
}
