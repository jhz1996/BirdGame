using UnityEngine;
using System.Collections;

public class camFire : MonoBehaviour {
	private Transform b;
	private CardboardHead ch;

	// Use this for initialization
	void Start () {
		ch = GetComponent<CardboardHead>();
	}
	
	public Transform bullet;
	
	// Update is called once per frame
	void Update()
	{
		//if (Input.GetMouseButtonDown(0))

		if(Time.frameCount % 15 == 0)
		{
			//you don't have to instantiate at the transform's positio nand rotation, swap these for what suits your needs
			//b = (Transform) Instantiate(bullet, transform.position, transform.);
			b = (Transform) Instantiate(bullet);
			b.gameObject.transform.position = transform.position;
			b.gameObject.transform.rotation = transform.rotation;
			Destroy(b.gameObject, 1);
//			print (transform.rotation);
//			print (Quaternion.Euler (ch.Gaze.direction));
			if(GameObject.Find("BirdBeeDrone") == null)
			{
				b.GetComponent<Renderer>().material.color = Color.cyan;
			}
		}
	}
}
