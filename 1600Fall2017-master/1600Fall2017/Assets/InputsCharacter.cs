using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputsCharacter : InputsStandard {

	// Use this for initialization
	void Update () {
		StandardInput(KeyCode.LeftArrow, Vector3.left);
		StandardInput(KeyCode.RightArrow, Vector3.right);
	}

}
