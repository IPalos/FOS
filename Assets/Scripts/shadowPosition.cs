using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowPosition : MonoBehaviour {

	public Transform lampara;
	public Transform pared;
	public Transform cubo;
	public float angulo;

	private float distCP; //distancia cubo-pared
	private float distLC; //distancia luz-cubo
	private float distLP; //distancia lampara-pared
	private float L;
	private float X;
	private float x;
	private float y;
	private float Y;

	private Vector3 pointCube;

	int layerMask = 1 << 8;


	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		RaycastHit hit;
		if (Physics.Raycast(lampara.position, (cubo.position-lampara.position), out hit, Mathf.Infinity, layerMask))
		{
				Debug.DrawRay(lampara.position,(cubo.position-lampara.position) * hit.distance, Color.yellow);
				// Debug.Log("Distancia"+hit.distance);
		}


		 distLC=Vector3.Distance(lampara.position,cubo.transform.position);
		 // distLP=Vector3.Distance(lampara.position,pared.transform.position);
		 distLP=(hit.distance);
		 distCP=distLC-distLP;

		 x=(cubo.position.x-lampara.position.x);
		 X=(x*distCP)/distLC;

		 y=(cubo.position.y-lampara.position.y);
		 Y=(y*distCP)/distLC;

		 // L=distLP/(distLC*Mathf.Cos(angulo));
		 L=distLP/distLC;
		 pointCube=lampara.position - cubo.position;

		 angulo=(Vector3.Angle(pointCube,cubo.forward))*Mathf.Deg2Rad;
		 // Debug.Log("CuboPared"+distCP);
		 // Debug.Log("LuzCubo"+distLC);
		 // Debug.Log("Angulo"+angulo*Mathf.Rad2Deg);


		 transform.localScale = new Vector3(L,L,L);
		 transform.position= new Vector3(cubo.position.x-X,cubo.position.y-Y,pared.position.z);







	}
}
