using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKiller : MonoBehaviour
{
    private const string _enemyTag = "Enemy";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(_enemyTag))
        {
            Destroy(collision.gameObject);
        }
    }
}
