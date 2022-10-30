using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _delay;

    private int _randomSpawnPosition;
    private WaitForSeconds _wait;

    private void Start()
    {
        _wait = new WaitForSeconds(_delay);
        StartCoroutine(GenerateEnemies());
    }

    private IEnumerator GenerateEnemies()
    {
        while(true)
        {
            _randomSpawnPosition = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemy, _spawnPoints[_randomSpawnPosition].transform.position, Quaternion.identity);
            yield return _wait;
        }
    }
}
