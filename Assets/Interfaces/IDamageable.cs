using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{

    void Damage(float damageAmount);

    void Capture();

    float MaxHealth { get; set; }

    float CurrentHealth { get; set; }
}
