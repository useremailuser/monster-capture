using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : EnemyState1
{
    private Transform _playerTransform1;
    private float _MovementSpeed1 = 4f;
    public Run(Enemy1 enemy1, EnemyStateMachine1 enemyStateMachine1) : base(enemy1, enemyStateMachine1)
    {
        _playerTransform1 = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void EnterState1()
    {
        base.EnterState1();
        _Text1.text = "Run";

        Debug.Log("Enter Run");
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override void ExitState1()
    {
        base.ExitState1();
    }

    public override void FrameUpdate1()
    {
        base.FrameUpdate1();

        Vector3 moveDirection = (enemy1.transform.position - _playerTransform1.position).normalized;

        enemy1.MoveEnemy1(moveDirection * _MovementSpeed1);


    }

    public override void PhysicsUpdate1()
    {
        base.PhysicsUpdate1();
    }
}
