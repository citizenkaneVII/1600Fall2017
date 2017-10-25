using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardMove : MonoBehaviour {

	// Use this for initialization
	public float speed = 3;
	CharacterController cc;
	void Start () {
		cc = GetComponent<CharacterController>();
		InputsCharacter.StandardInput += Move;
	}
	
	void Move (KeyCode _i, Vector3 _v) {
		if (Input.GetKey(_i))
		{
			cc.Move(_v*speed*Time.deltaTime);
		}
	}
}
