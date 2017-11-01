using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour{

public CharacterControl characterControl;
public static bool gameOver = false;
public float gravity = 9.81f;
public float speed = 10;
public Vector3 moveVector3;
public float jumpForce = 20;
void fixedUpdate () {
    if(characterControl.isGrounded && !gameOver)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                moveVector3.y += jumpForce * Time.deltaTime;
            }
            moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
        characterControl.Move(moveVector3);
    }



}