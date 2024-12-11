using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAggroCheck1 : MonoBehaviour
{

    public GameObject PlayerTarget { get; set; }
    public Enemy1 _enemy1;

    private void Awake()
    {
        PlayerTarget = GameObject.FindGameObjectWithTag("Player");

        _enemy1 = GetComponentInParent<Enemy1>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == PlayerTarget)
        {
            _enemy1.SetAggroStatus1(true);
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject == PlayerTarget)
        {
            _enemy1.SetAggroStatus1(false);
        }
    }

}
