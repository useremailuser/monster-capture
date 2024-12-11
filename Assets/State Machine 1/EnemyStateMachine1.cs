using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine1
{
    public EnemyState1 CurrentEnemyState1 { get; set; }

    public void Initialize(EnemyState1 startingState1)
    {
        CurrentEnemyState1 = startingState1;
        CurrentEnemyState1.EnterState1();
    }

    public void ChangeState1(EnemyState1 newState1)
    {
        CurrentEnemyState1.ExitState1();
        CurrentEnemyState1 = newState1;
        CurrentEnemyState1.EnterState1();
    }
}
