using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    private Transform spherePosition;

    public float xDistance = 3f;
    public float yDistance = 4f;
    public float zDistance = 7f;

    // Start is called before the first frame update
    private void Awake()
    {
        spherePosition = GameObject.Find("AshkansSphere").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.y = spherePosition.position.y + yDistance;
        temp.z = spherePosition.position.z + zDistance;
        temp.x = spherePosition.position.x + xDistance;
        transform.position = temp;

    }
}
