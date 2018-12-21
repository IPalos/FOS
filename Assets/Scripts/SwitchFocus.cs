using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets._2D;

//Script para cambiar el enfoque entre los controles FirstPerson y los distintos murales

public class SwitchFocus : MonoBehaviour {

	public GameObject protagonista;
	public GameObject mural1;

	private FirstPersonController fpcontroller;
	private PlatformerCharacter2D ddcontroller;

	// Use this for initialization
	void Start () {
		protagonista=GameObject.Find("Protagonista");
		fpcontroller =protagonista.GetComponent<FirstPersonController>();

		mural1=GameObject.Find("2DCharacter");
		ddcontroller =mural1.GetComponent<PlatformerCharacter2D>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F)){
			ToggleMovement();
		}
	}

	void ToggleMovement (){
		ddcontroller.m_canWalk=fpcontroller.m_canWalk;
		fpcontroller.m_canWalk=!fpcontroller.m_canWalk;
		Debug.Log(fpcontroller.m_canWalk);
	}

}
