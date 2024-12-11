using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public interface ITriggerCheckable
{

    bool IsAggroed { get; set; }
    bool IsWithinDistance { get; set; }
    void SetAggroStatus(bool isAggroed);
    void SetDistance(bool isWithinDistance);
}
