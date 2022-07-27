using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] public GameObject lastCube;
    private GameObject newCube;
    private int scaleCube = 1;
    private int cubeSpawnIndex;
    private Vector3 newCubePos;

    private void Start()
    {
        SpawnCube();
    }
    private void SpawnCube()
    {
        for (int i = 0; i < 100; i++)
        {
            newCube = Instantiate(lastCube, LastCubePosition(), Quaternion.identity);
            lastCube = newCube;
        }
    }

    public Vector3 LastCubePosition()
    {
        cubeSpawnIndex = Random.Range(0, 2);

        if (cubeSpawnIndex==0)
        {
            newCubePos = new Vector3(lastCube.transform.position.x + scaleCube, lastCube.transform.position.y, lastCube.transform.position.z);

        }
        else if (cubeSpawnIndex == 1)
        {
            newCubePos = new Vector3(lastCube.transform.position.x, lastCube.transform.position.y , lastCube.transform.position.z + scaleCube);
        }
        return newCubePos;
    }
}
