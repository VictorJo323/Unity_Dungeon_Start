using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Stat", menuName = "New Stat")]
public class StatData : ScriptableObject
{
    [Header("Base Stats")]
    public int maxHealth;
    public int baseAttack;
    public int baseDefence;
    public float critRate;

    [Header("Current Stats")]
    [HideInInspector] public int curHealth;
}
