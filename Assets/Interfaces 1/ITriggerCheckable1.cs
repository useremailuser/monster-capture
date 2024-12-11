using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public interface ITriggerCheckable1
{

    bool IsAggroed1 { get; set; }
    bool IsWithinDistance1 { get; set; }
    void SetAggroStatus1(bool isAggroed);
    void SetDistance1(bool isWithinDistance);
}
