using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float RotationSpeed;



    void FixedUpdate()
    {
        gameObject.transform.RotateAround(gameObject.transform.position, transform.up, RotationSpeed);

    }
}