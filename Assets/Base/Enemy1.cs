using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy1 : MonoBehaviour, IDamageable1, IEnemyMovement1, ITriggerCheckable1
{
    [field: SerializeField] public float MaxHealth { get;  set; }
    public float CurrentHealth { get; set; }
    public Rigidbody RB { get; set; }
    public NavMeshAgent NavMeshAgent { get; set; }
    public bool isFacingRight { get; set; }

    public Text _Text1;
    #region Idle Variables

    public Rigidbody ProjPrefab;
    public float RandomMovementRange = 5f;
    public float RandomMovementSpeed = 1f;


    #endregion

    private void Awake()
    {
        StateMachine1 = new EnemyStateMachine1();
        Idle1State = new Idle1(this, StateMachine1);
        Run1State = new Run(this, StateMachine1); 
    }

    public EnemyStateMachine1 StateMachine1 { get; set; }
    public Run Run1State { get; private set; }
    public Idle1 Idle1State { get; set; }
    public bool IsAggroed1 { get; set; }
    public bool IsWithinDistance1 { get; set; }

    private void Start()
    {
        CurrentHealth = MaxHealth;

        RB = GetComponent<Rigidbody>();
        
        StateMachine1.Initialize(Idle1State);
    }

    private void Update()
    {
        StateMachine1.CurrentEnemyState1.FrameUpdate1();
        if (CompareTag("Enemy1"))
        {
            _Text1.text = "attack";

            Debug.Log("enemy1 working");
            StateMachine1.ChangeState1(Idle1State);
        }
    }

    private void FixedUpdate1()
    {
        StateMachine1.CurrentEnemyState1.PhysicsUpdate1();
    }
    public void Damage1(float damageAmount)
    {
        CurrentHealth -= damageAmount;
        
        if (CurrentHealth <= 0f)
        {
            Capture1();
        }
    }


    public void Capture1()
    {
        
    }

    #region Movement Functions
    public void MoveEnemy1(Vector3 velocity1)
    {
      RB.velocity = velocity1;

    }

   
    #endregion

    #region Triggers

    #endregion
    #region Distance Checks
    public void SetAggroStatus1(bool isAggroed1)
    {
        IsAggroed1 = isAggroed1;
    }

    public void SetDistance1(bool isWithinDistance1)
    {
       IsWithinDistance1 = isWithinDistance1;
    }
    #endregion

}
