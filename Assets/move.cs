using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		transform.position +=
			new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
	}
	void Input(){
		
	}
}
