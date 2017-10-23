using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCharacter : MonoBehaviour {

	Animator anims;

	void Start () {
		anims = GetComponent<Animator>();
		MoveInput.MoveAction += Animate;
		anims.SetTrigger("IsLoaded");
	}
	
    private void Animate(float obj)
    {
        anims.SetFloat("Walk", obj);
    }
}
