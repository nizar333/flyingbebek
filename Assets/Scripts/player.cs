using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public AudioClip coinCollectSound;
	private uint coins = 0;
	public float speed = 5.0f;

	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 5){

			transform.position += Vector3.right;
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -5){

			transform.position += Vector3.left;
		}

		if(Input.GetKeyDown(KeyCode.UpArrow)&& transform.position.y < 3){

			transform.position += Vector3.up;
		}

		if(Input.GetKeyDown(KeyCode.DownArrow)&& transform.position.y > 1){

			transform.position += Vector3.down;
		}
	
	}

	void CollectCoin(Collider coinCollider)
	{
		coins++;

		Destroy(coinCollider.gameObject);

		AudioSource.PlayClipAtPoint(coinCollectSound, transform.position);
	}
	//void OnTriggerEnter(Collider other){
		//if(other.tag == "batang"){
			//Application.LoadLevel(Application.loadedLevel);
		//}
	//}




		



}
