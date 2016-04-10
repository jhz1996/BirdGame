using UnityEngine;
using System.Collections;

public class CircularOrbit : MonoBehaviour {
	private GameObject bbd;
	private GameObject child;

	public Transform center;
	public float degreesPerSecond = -65.0f;
	
	private Vector3 v;
	
	void Start() {
		v = transform.position - center.position;
		bbd = GameObject.Find ("BirdBeeDrone");
	}
	
	void Update () {
		v = Quaternion.AngleAxis (degreesPerSecond * Time.deltaTime, Vector3.up) * v;
		transform.position = center.position + v;

		if(transform.parent == null)
			transform.rotation = transform.rotation * Quaternion.Euler (0,Time.deltaTime * degreesPerSecond,0);

		if(transform.parent == null && Time.frameCount % 1200 == 0) {
			child = (GameObject) Instantiate (bbd, new Vector3(0,1,-2), Quaternion.identity);
			child.transform.parent = bbd.transform;
		}
	}
}