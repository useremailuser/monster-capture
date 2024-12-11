using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable1
{

    void Damage1(float damageAmount1);

    void Capture1();

    float MaxHealth { get; set; }

    float CurrentHealth { get; set; }
}
