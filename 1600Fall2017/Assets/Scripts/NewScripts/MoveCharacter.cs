using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class MoveCharacter : MonoBehaviour {

	CharacterController cc;
	Vector3 tempMove;
    public float speed = 5;
    public float gravity = 1;
    public float jumpHeight = 0.2f;

    void Start () {
		cc = GetComponent<CharacterController>();
		MoveInput.JumpAction = Jump;
		MoveInput.MoveAction += Move;
	}

	void Jump () {
		tempMove.y = jumpHeight;
	}

	void Move (float _movement) {
		tempMove.y = -gravity*Time.deltaTime;
		tempMove.x = _movement*speed*Time.deltaTime;
		cc.Move(tempMove);
	}
}
