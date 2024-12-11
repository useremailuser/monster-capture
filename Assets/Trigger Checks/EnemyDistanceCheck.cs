using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistanceCheck : MonoBehaviour
{
    public GameObject PlayerTarget { get; set; }
    public Enemy _enemy;

    private void Awake()
    {
        PlayerTarget = GameObject.FindGameObjectWithTag("Player");

        _enemy = GetComponentInParent<Enemy>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == PlayerTarget)
        {
            _enemy.SetDistance(true);
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject == PlayerTarget)
        {
            _enemy.SetDistance(false);
        }
    }


}
