using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public GameObject ball;
    public Vector3 distance;

    private void Start()
    {
        distance = transform.position - ball.transform.position;
    }
    private void LateUpdate()
    {
        transform.position = ball.transform.position + distance;
    }

}




