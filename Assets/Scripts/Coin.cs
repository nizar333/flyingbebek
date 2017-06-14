using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public int spawnTime;

	private int timer;

	// Use this for initialization
	void Start () {

		coin();
	}

	// Update is called once per frame
	void Update () {

		timer++;

		if(timer >= spawnTime){

			coin();
			timer = 0;
		}

	}

	void coin(){

		Instantiate (Resources.Load ("coin"));
	}
}
