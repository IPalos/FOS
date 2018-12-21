using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showInventory : MonoBehaviour {

	public GameObject inventory;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		switchinventory();

	}

void switchinventory(){

	if (Input.GetKeyDown("i")){

		if (inventory.activeSelf){
			inventory.SetActive(false);
		}
		else{
			inventory.SetActive(true);
		}

	}
}


}
