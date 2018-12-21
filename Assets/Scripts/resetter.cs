using UnityEngine;
using UnityEngine.SceneManagement;

public class resetter : MonoBehaviour {

	private float tiempo = 0f;

	// Update is called once per frame
	void Update () {

		if  (Input.GetKey("y") || Mathf.Floor(tiempo)==120 ){
			SceneManager.LoadScene("MainMenu");
		}

		wiu();


	}

	void wiu(){

		if (!Input.anyKeyDown){
			tiempo+=Time.deltaTime;
		}

		else{
			tiempo = 0f;
		}

	}

}
