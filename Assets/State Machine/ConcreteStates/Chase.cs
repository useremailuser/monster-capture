using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chase : EnemyState
{
    private Text _text1;
    private Transform _playerTransform;
    private float _MovementSpeed = 4f;
    public Chase(Enemy enemy, EnemyStateMachine enemyStateMachine) : base(enemy, enemyStateMachine)
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void EnterState()
    {
        base.EnterState();

        Debug.Log("Enter Chase");
        _text1.text = "chase";
    }

    public override void ExitState()
    {
        base.ExitState();
    }

    public override void FrameUpdate()
    {
        base.FrameUpdate();

        Vector3 moveDirection = (_playerTransform.position - enemy.transform.position).normalized;

        enemy.MoveEnemy(moveDirection * _MovementSpeed);

        if(enemy.IsWithinDistance)
        {
            enemy.StateMachine.ChangeState(enemy.AttackState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    void start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
