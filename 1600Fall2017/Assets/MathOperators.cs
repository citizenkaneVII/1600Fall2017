using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

	// Use this for initialization
	public float num1;
	public float num2;

	public float addResult;
	public float subResult;
	public float multResult;
	public float divResult;
	public float remainderResult;

	// Update is called once per frame
	void Update () {
		addResult = num1 + num2;
		subResult = num1 - num2;
		multResult = num1 * num2;
		if(num1 != 0 && num2 != 0) {
			divResult = num1 / num2;	
		} else {
			print("Can't Divide By 0.");
		}
		remainderResult = num1 % num2;
	}
}
