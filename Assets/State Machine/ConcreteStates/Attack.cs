using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : EnemyState
{
    private Transform _playerTransform;

    private float _timer;
    private float _timeBetweenShots = 2f;

    private float _exitTimer;
    private float _timeTillExit = 3f;
    private float _distanceToCountExit = 3f;

    private float _bulletSpeed = 10f;
    public Attack(Enemy enemy, EnemyStateMachine enemyStateMachine) : base(enemy, enemyStateMachine)
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void EnterState()
    {
        base.EnterState();

        Debug.Log("Enter Attack");
        _Text.text = "attack";
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FrameUpdate()
    {
        base.FrameUpdate();

        enemy.MoveEnemy(Vector3.zero);

        if(_timer > _timeBetweenShots)
        {
            _timer = 0f;

            Vector3 dir = (_playerTransform.position - enemy.transform.position).normalized;

            Rigidbody proj = GameObject.Instantiate(enemy.ProjPrefab, enemy.transform.position, Quaternion.identity);
            proj.velocity = dir * _bulletSpeed;
        }
        if (Vector3.Distance(_playerTransform.position, enemy.transform.position) > _distanceToCountExit)
        {
            _exitTimer += Time.deltaTime;
            if (_exitTimer > _timeTillExit)
            {
                enemy.StateMachine.ChangeState(enemy.ChaseState);
            }
        }

        else
        {
            _exitTimer = 0f;
        }

        _timer += Time.deltaTime;
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
