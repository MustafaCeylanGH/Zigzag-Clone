using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    private SpawnManager spawnManager;
    private Rigidbody rb;

    private void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        GroundPositionControl();
    }
    private void GroundPositionControl()
    {
        if (transform.position.y <= -8)
        {
            rb.isKinematic = true;
            transform.position = spawnManager.LastCubePosition();
            spawnManager.lastCube = this.gameObject;
        }
    }
}
