using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suivi_Camera : MonoBehaviour
{

    public Transform personnage;
    public float dampTime = 0.4f;
    private Vector3 Poscamera;
    private Vector3 velocity = Vector3.zero;


    void Update()
    {
        Poscamera = new Vector3(personnage.position.x, personnage.position.y, -10f);
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, Poscamera, ref velocity, dampTime);
    }
}
