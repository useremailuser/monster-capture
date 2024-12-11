using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public interface IEnemyMovement
{
    Rigidbody RB {  get; set; }
    NavMeshAgent NavMeshAgent { get; set; }
    bool isFacingRight {  get; set; }
    // Update is called once per frame
    void MoveEnemy(Vector3 velocity);
 
}
