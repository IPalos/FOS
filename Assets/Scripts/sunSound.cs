using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunSound : MonoBehaviour {

  AudioSource sunMoving;
  AudioSource SwithOn;

	public AudioClip SunFadeIn;
	public AudioClip SunMove;
	public AudioClip SunFadeOut;
  public AudioClip SunOn;


	public GameObject lampara;
	private moveCube move;

  public GameObject sunSwitch;

	private float tiempo;

	// Use this for initialization
	void Start () {

		sunMoving= GetComponent<AudioSource>();
		move = lampara.GetComponent<moveCube>();

    SwithOn = sunSwitch.GetComponent<AudioSource>();


	}

	// Update is called once per frame
	void Update () {

		sunMoving.loop=move.sunIsMoving;

    if (!SwithOn.isPlaying && move.canPlaySound){
      SwithOn.clip= SunOn;
      SwithOn.loop=false;
      SwithOn.Play();
    }


		if (move.sunIsMoving && !sunMoving.isPlaying){
			sunMoving.clip = SunMove;
			sunMoving.Play();
		}
		// if (sunMoving.isPlaying && move.sunIsMoving){
		// 	sunMoving.clip = SunMove;
		// 	sunMoving.loop=true;
		// 	sunMoving.Play();
		// }

		else if (!move.sunIsMoving && sunMoving.clip==SunMove){
			sunMoving.loop=false;
			sunMoving.clip= SunFadeOut;
			sunMoving.Play();

			// tiempo=0;
		}


	}
}
