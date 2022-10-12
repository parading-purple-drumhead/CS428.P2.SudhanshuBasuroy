using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBill : MonoBehaviour
{
    // public GameObject prefab;

    // public Vector3 spawnPosition;

    public GameObject reference;

    public void OnSpawnPrefab()
    {
        Debug.Log("Object created");

        Debug
            .Log("Cube's position: " +
            reference.transform.position.x +
            " " +
            reference.transform.position.y +
            " " +
            reference.transform.position.z);
        // var created = Instantiate(prefab, spawnPosition, Quaternion.identity);
        // Debug.Log(created.transform.position);
    }

    private void Start()
    {
        OnSpawnPrefab();
    }
}
