using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private Vector3 offset;
    [SerializeField] [Range(0, 2)] float smoothValue;

    private void Start()
    {
        offset = transform.position - ball.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, ball.transform.position + offset, smoothValue * Time.deltaTime);
    }
}
