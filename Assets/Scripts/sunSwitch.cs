	﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunSwitch : MonoBehaviour {

	public GameObject lampara;
	private moveCube move;

	private Transform cubes;

	private GameObject cube1;
	private GameObject cube2;
	private GameObject cube3;
	private Light lt;
	private GameObject sphe;


	void Start(){
			move = lampara.GetComponent<moveCube>();
			cubes= transform.GetChild(0);

			cube1=cubes.GetChild(0).gameObject;
			cube2=cubes.GetChild(1).gameObject;
			cube3=cubes.GetChild(2).gameObject;
			lt=cubes.GetChild(3).gameObject.GetComponent<Light>();
			sphe=cubes.GetChild(4).gameObject;


	}

	void OnTriggerEnter2D(Collider2D other){
			move.canPlaySound = true;
	}

	void OnTriggerStay2D(Collider2D other)
	{
			move.canMoveSun = true;
			Debug.Log("Sun Activate!");
			move.canPlaySound=false;


	}

	void OnTriggerExit2D(Collider2D other){
			move.canMoveSun = false;
			move.canPlaySound = false;

	}

	void Update(){
		if (move.canMoveSun){
			cube1.transform.Rotate(0,Time.deltaTime*-20,0);
			cube2.transform.Rotate(Time.deltaTime*20,0,0);
			cube3.transform.Rotate(0,0,Time.deltaTime*-20);
			cube1.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
			cube2.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
			cube3.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
			lt.intensity = 5;
			sphe.transform.localScale = new Vector3(1.5f,1.5f,1.5f);


		}
		else{
			cube1.transform.localScale = new Vector3(1,1,1);
			cube2.transform.localScale = new Vector3(1,1,1);
			cube3.transform.localScale = new Vector3(1,1,1);
			lt.intensity=0;
			sphe.transform.localScale = new Vector3(1,1,1);

		}
	}

}
