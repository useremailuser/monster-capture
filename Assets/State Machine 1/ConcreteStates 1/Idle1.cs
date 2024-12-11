using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle1 : EnemyState1
{
    private Vector3 _targetPos1;
    private Vector3 _direction1;
    public Idle1(Enemy1 enemy1, EnemyStateMachine1 enemyStateMachine1) : base(enemy1, enemyStateMachine1)
    {

    }


    public override void EnterState1()
    {
        base.EnterState1();

        _targetPos1 = GetRandomPointInCircle1();
    }

    public override void ExitState1()
    {
        base.ExitState1();

        Debug.Log("Exit Idle1");

    }

    public override void FrameUpdate1()
    {
        base.FrameUpdate1();

        if (enemy1.IsAggroed1)
        {
            enemy1.StateMachine1.ChangeState1(enemy1.Run1State);
        }

        _targetPos1.y = 2.2f;

        _direction1 = (_targetPos1 - enemy1.transform.position).normalized;

        enemy1.MoveEnemy1(_direction1 * enemy1.RandomMovementSpeed);
        
        if ((enemy1.transform.position - _targetPos1).sqrMagnitude < 0.01f)
        {
            _targetPos1 = GetRandomPointInCircle1();
        }
    }


    public override void PhysicsUpdate1()
    {
        base.PhysicsUpdate1();
    }

    private Vector3 GetRandomPointInCircle1()
    {
        return enemy1.transform.position + ((Vector3)UnityEngine.Random.insideUnitSphere * enemy1.RandomMovementRange);
    }


}
