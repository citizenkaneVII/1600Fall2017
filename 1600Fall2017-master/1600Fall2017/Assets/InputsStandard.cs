using UnityEngine;
using System;

public class InputsStandard : MonoBehaviour {

	public static Action<KeyCode, Vector3> StandardInput;

	void Update () {
		StandardInput(KeyCode.UpArrow, Vector3.up);
		StandardInput(KeyCode.DownArrow, Vector3.down);
		StandardInput(KeyCode.LeftArrow, Vector3.forward);
		StandardInput(KeyCode.RightArrow, Vector3.back);
	}
}
