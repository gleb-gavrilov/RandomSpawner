using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _delay;

    private int _randomSpawnPosition;
    private float _timeBetweenSpawn;

    private void Start()
    {
        _timeBetweenSpawn = _delay;
    }

    private void Update()
    {
        if (_timeBetweenSpawn <= 0)
        {
            _randomSpawnPosition = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemy, _spawnPoints[_randomSpawnPosition].transform.position, Quaternion.identity);
            _timeBetweenSpawn = _delay;
        }
        else
        {
            _timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
