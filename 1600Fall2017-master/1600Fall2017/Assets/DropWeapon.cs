using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWeapon : MonoBehaviour {

	public Transform weapon;

	void OnTriggerEnter()
	{
		weapon.parent = null;
	}

}
