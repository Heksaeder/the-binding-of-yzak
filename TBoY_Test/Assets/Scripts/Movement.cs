using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/************************************
Movement gère les déplacements du personnage par le biais des touches directionnelles.
************************************/

public class Movement : MonoBehaviour
{

    public float moveSpeed = 10.0f; // adjust as needed
    float moveRight;
    float moveLeft;
    float moveUp;
    float moveDown;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            moveRight = moveSpeed;
        }
        else {
            moveRight = 0.0f;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            moveLeft = -moveSpeed;
        }
        else {
            moveLeft = 0.0f;
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            moveUp = moveSpeed;
        }
        else {
            moveUp = 0.0f;
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            moveDown = -moveSpeed;
        }
        else {
            moveDown = 0.0f;
        }
    }

    void FixedUpdate() {
        transform.position += new Vector3(moveRight + moveLeft, moveUp + moveDown, 0);
    }
}
