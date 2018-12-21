using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunAutocontroller : MonoBehaviour {

	public GameObject lampara;
	private moveCube move;

	// public GameObject AutoController;
	// private values val;

	public int ida=2;
	public int vuelta=4;
	public int Pong=6;
	public float tiempo;

	public Vector3 dir;


	// Use this for initialization
	void Start () {
				move = lampara.GetComponent<moveCube>();
				// val=AutoController.GetComponent<values>();
				// dir=new Vector3(val.x, val.y,0f);
	}

	void Awake (){
		tiempo=0f;
	}

	// Update is called once per frame
	void Update () {

			tiempo+=Time.deltaTime;


			if(Mathf.PingPong(Mathf.Floor(tiempo),Pong)<ida){
				move.canMoveSun=true;
				lampara.transform.Translate(Time.deltaTime*move.speed*dir.x,Time.deltaTime*move.speed*dir.y,0f);
				move.sunIsMoving=true;

			}
			else if (Mathf.PingPong(Mathf.Floor(tiempo),Pong)>vuelta) {
				move.canMoveSun=true;
				lampara.transform.Translate(Time.deltaTime*move.speed*dir.x*-1,Time.deltaTime*move.speed*dir.y*-1,0f);
				move.sunIsMoving=true;

			}

			else{
				move.canMoveSun=false;
				move.sunIsMoving=false;
			}



	}
}
