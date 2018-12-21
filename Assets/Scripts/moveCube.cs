using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour {

	public float speed =1f;
	public bool canMoveSun;
	public bool sunIsMoving;
	public bool canPlaySound = false;

	// Use this for initialization
	void Start () {

		canPlaySound = false;

	}

	// Update is called once per frame
	void Update () {

		sunIsMoving=false;

		if (canMoveSun){

			if (Input.GetKey("h")){
				transform.Translate(Time.deltaTime*speed,0f,0f);
				sunIsMoving=true;
			}

			if (Input.GetKey("k")){
				transform.Translate(Time.deltaTime*-1*speed,0f,0f);
				sunIsMoving=true;
			}

			if (Input.GetKey("u")){
				transform.Translate(0f,Time.deltaTime * -1*speed,0f);
				sunIsMoving=true;
			}

			if (Input.GetKey("j")){
				transform.Translate(0f, Time.deltaTime*speed ,0f);
				sunIsMoving=true;
			}


		}

	}

}
