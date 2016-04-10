using UnityEngine;
using System.Collections;

public class transform : MonoBehaviour {
	public float speed;
	public float deploymentHeight;

	// Update is called once per frame
	void Update () {
		transform.Translate(transform.forward * speed * Time.deltaTime);
	}

	void FixedUpdate() {
		RaycastHit hit;

		if(Physics.Raycast (transform.position, Vector3.forward, out hit, deploymentHeight))
		{
			if(hit.collider.tag == "Enemy")
			{
				Destroy(this.gameObject);
				Destroy(hit.collider.gameObject);
			}
		}
	}
}
