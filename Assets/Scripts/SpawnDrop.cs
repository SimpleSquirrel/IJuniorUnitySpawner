using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDrop : MonoBehaviour
{
    public GameObject Template;

    public void SpawnNewDrop()
    {
        var spawnCoordinates = GetComponent<Transform>();
        Instantiate(Template, new Vector3(spawnCoordinates.position.x, spawnCoordinates.position.y, 0), Quaternion.identity);
    }
}
