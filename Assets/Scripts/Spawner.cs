using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _delay;

    private int _randomSpawnPosition;
    private Coroutine _generateEnemies;

    private void Update()
    {
        if (_generateEnemies == null)
        {
            _generateEnemies = StartCoroutine(GenerateEnemies());
        }
    }

    private IEnumerator GenerateEnemies()
    {
        _randomSpawnPosition = Random.Range(0, _spawnPoints.Length);
        Instantiate(_enemy, _spawnPoints[_randomSpawnPosition].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(_delay);
        _generateEnemies = null;
    }
}
