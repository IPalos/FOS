using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerReset : MonoBehaviour {

public Transform respawnPoint;
public GameObject spot;

private Vector3 startPos;

	void Start (){
		startPos=spot.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("r")){
			transform.position=respawnPoint.position;
			spot.transform.position= startPos;

		}
	}
}
