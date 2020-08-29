using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomizeSpawn : MonoBehaviour
{
    private List<SpawnDrop> _spawners;
    [SerializeField] private float _spawnCooldownTime;
    private float _cooldownTime;
    public void Start()
    {
        _spawners = FindObjectsOfType<SpawnDrop>().ToList();
    }
    public void Update()
    {
        if (_cooldownTime >= _spawnCooldownTime)
        {
            int choosenSpawner = Random.Range(0, _spawners.Count);
            _spawners[choosenSpawner].SpawnNewDrop();
            _cooldownTime = 0;
        }
        else
        {
            _cooldownTime += Time.deltaTime;
        }
        
    }

}
