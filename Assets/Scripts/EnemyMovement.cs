using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private int _speed = 4;
    private Vector3 _center = Vector3.zero;
    
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _center, _speed * Time.deltaTime);
    }
}
