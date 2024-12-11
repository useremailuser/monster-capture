using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyState
{
    protected Enemy enemy;
    protected EnemyStateMachine enemyStateMachine;
    public static Text _Text;

    public EnemyState(Enemy enemy, EnemyStateMachine enemyStateMachine)
    {
        this.enemy = enemy;
        this.enemyStateMachine = enemyStateMachine;
    }
    public virtual void EnterState() { }
    public virtual void ExitState() { }
    public virtual void FrameUpdate() { }
    public virtual void PhysicsUpdate() { }

    public virtual void AnimationTriggerEvent(Enemy.AnimationTriggerType triggerType) { }

    public void start()
    {
        _Text = GameObject.Find("Text").GetComponent<Text>();
    }
}
