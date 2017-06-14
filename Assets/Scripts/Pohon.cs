using UnityEngine;
using System.Collections;

public class Pohon : MonoBehaviour {

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

		Instantiate (Resources.Load ("pohon"));
	}
}
