using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRespawn : MonoBehaviour {

	public GameObject player;
	AudioSource playerSounds;

	public AudioClip respawnBoom;

	public GameObject respawnPoint;

	void Start(){
		playerSounds=player.GetComponent<AudioSource>();
	}

	void OnTriggerEnter2D(Collider2D player){
		player.transform.position =  respawnPoint.transform.position;
		player.GetComponent<Rigidbody2D>().velocity= Vector3.zero;
		playerSounds.clip=respawnBoom;
		playerSounds.volume= .1f;
		playerSounds.Play();
	}
}
