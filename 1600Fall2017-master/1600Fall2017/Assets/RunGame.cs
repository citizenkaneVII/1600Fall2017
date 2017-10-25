using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunGame : MonoBehaviour {

	public Toggle toggle;
    public float health = 100;

    // Update is called once per frame
    void Update () {
		if (toggle.isOn)
		{
			print("Play Game");
		} else {
			print("Can't Play.");
		}

		health -= 0.01f;
	}
}
