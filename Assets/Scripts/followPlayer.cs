using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

public GameObject player;
public bool isFollowing;
public Vector3 pos;

private float x=0;
private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
		isFollowing = false;


	}

	// Update is called once per frame
	void Update () {
		x+=Time.deltaTime;
		follow();


	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == player.name)
				Debug.Log("Crash");
				isFollowing=true;

}

	void follow(){
		pos=transform.position;
		rigidBody = GetComponent<Rigidbody2D>();
		if (isFollowing){
			rigidBody.gravityScale=0f;
			transform.position= player.transform.position-(Vector3.left*Mathf.Sin(x)*2)+Vector3.up*2+(Vector3.back*Mathf.Cos(x)*2);
			if (Input.GetAxis("Fire2")==1){
				isFollowing = false;
			}
		}
		else{
			transform.position=pos;
			// rigidBody.gravityScale=1.0f;

		}


	}

}
