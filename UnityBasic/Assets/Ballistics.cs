using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballistics : MonoBehaviour
{

    Rigidbody body;

    private void Update()
    {

        Mechanics();
    }

    private void Mechanics()
    {
        float time = Time.time;

        body.AddForce(Vector3.down * time);

    }



}
