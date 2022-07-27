using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private Color[] colors;
    [SerializeField] private Material material;
    private float currentTime;
    private float time = 2.0f;
    private int colorIndex;
    [SerializeField] [Range(0,2)] float smoothValue;

    private void Start()
    {
        material = cubePrefab.GetComponent<MeshRenderer>().sharedMaterial;
        currentTime = time;
    }
    private void Update()
    {
        ColorControl();
        ColorChangeSmooth();
    }

    private void ColorControl()
    {
        if (currentTime>=0)
        {           
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = time;
                colorIndex++;

                if (colorIndex >= colors.Length)
                {
                    colorIndex = 0;
                }               
            }
        }       
    }

    private void ColorChangeSmooth()
    {
        material.color = Color.Lerp(material.color, colors[colorIndex], smoothValue*Time.deltaTime);
    }
}
