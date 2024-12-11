using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, IDamageable, IEnemyMovement, ITriggerCheckable
{
    [field: SerializeField] public float MaxHealth { get;  set; }
    public float CurrentHealth { get; set; }
    public Rigidbody RB { get; set; }
    public NavMeshAgent NavMeshAgent { get; set; }
    public bool isFacingRight { get; set; }

    #region Idle Variables

    public Rigidbody ProjPrefab;
    public float RandomMovementRange = 5f;
    public float RandomMovementSpeed = 1f;


    #endregion

    private void Awake()
    {
        StateMachine = new EnemyStateMachine();
        IdleState = new Idle(this, StateMachine);
        ChaseState = new Chase(this, StateMachine);
        AttackState = new Attack(this, StateMachine);
    }

    public EnemyStateMachine StateMachine { get; set; }
    public Idle IdleState { get; set; }
    public Chase ChaseState { get; set; }
    public Attack AttackState { get; set; }
    public bool IsAggroed { get; set; }
    public bool IsWithinDistance { get; set; }

    private void Start()
    {
        CurrentHealth = MaxHealth;

        RB = GetComponent<Rigidbody>();
        
        StateMachine.Initialize(IdleState);
    }

    private void Update()
    {
        StateMachine.CurrentEnemyState.FrameUpdate();
        if (CompareTag("Enemy1"))
        {
            Debug.Log("enemy1 working");
            StateMachine.ChangeState(IdleState);
        }
    }

    private void FixedUpdate()
    {
        StateMachine.CurrentEnemyState.PhysicsUpdate();
    }
    public void Damage(float damageAmount)
    {
        CurrentHealth -= damageAmount;
        
        if (CurrentHealth <= 0f)
        {
            Capture();
        }
    }


    public void Capture()
    {
        
    }

    #region Movement Functions
    public void MoveEnemy(Vector3 velocity)
    {
      RB.velocity = velocity;

    }

   
    #endregion

    #region Triggers
    private void AnimationTriggerEvent(AnimationTriggerType triggerType)
    {
        StateMachine.CurrentEnemyState.AnimationTriggerEvent(triggerType);
    }

    public enum AnimationTriggerType
    {
        EnemyDamaged,
        Caught
    }

    #endregion
    #region Distance Checks
    public void SetAggroStatus(bool isAggroed)
    {
        IsAggroed = isAggroed;
    }

    public void SetDistance(bool isWithinDistance)
    {
       IsWithinDistance = isWithinDistance;
    }
    #endregion

}
