using UnityEngine;
using System.Collections;

public class camControls : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	void Update () {

        var mouseX = Input.GetAxis("Mouse X"); //get x
        var mouseY = Input.GetAxis("Mouse Y");
 Vector3 movementVector = new Vector3(mouseY, mouseX, 0); //Perhaps arrange your values into a Vector3 if you're multiplying by the same sensitivity?
        //transform.rotate(movementVector * camSensitivity);

    }
}
