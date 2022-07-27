using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] private float moveSpeed;
    

    private void Start()
    {        
        direction = Vector3.forward;
    }

    private void Update()
    {
        BallMovement();
        DirectionControl();
    }

    private void BallMovement()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    private void DirectionControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (direction == Vector3.forward)
            {
                direction = Vector3.right;
            }else if (direction == Vector3.right)
            {
                direction = Vector3.forward;
            }            
        }
    }
}
