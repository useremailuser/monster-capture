using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public interface IEnemyMovement1
{
    Rigidbody RB {  get; set; }
    NavMeshAgent NavMeshAgent { get; set; }
    bool isFacingRight {  get; set; }
    // Update is called once per frame
    void MoveEnemy1(Vector3 velocity);
 
}
