using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text hiScoreText;

	public int hiScore;
	public int cointValue;

	public GameObject explosion;
	// Use this for initialization
	void Start () {
		cointValue = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		scoreText.text = "Score: " + cointValue.ToString();
		hiScoreText.text = "High Score: " + hiScore;
	}

	public void OnTriggerEnter(Collider other)
	{		
		if (other.gameObject.tag == "coin") {
			Debug.Log ("coin");
			cointValue = cointValue + 1;
			Destroy (other.gameObject);
		}
	}
}
