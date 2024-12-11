using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyState1
{
    protected Enemy1 enemy1;
    protected EnemyStateMachine1 enemyStateMachine1;
    public static Text _Text1;

    public void start()
    {
        _Text1 = GameObject.Find("Text1").GetComponent<Text>();
    }
    public EnemyState1(Enemy1 enemy1, EnemyStateMachine1 enemyStateMachine1)
    {
        this.enemy1 = enemy1;
        this.enemyStateMachine1 = enemyStateMachine1;
    }
    public virtual void EnterState1() { }
    public virtual void ExitState1() { }
    public virtual void FrameUpdate1() { }
    public virtual void PhysicsUpdate1() { }

}
