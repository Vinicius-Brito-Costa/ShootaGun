using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/BossData")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private new string name = "Monster Name";
    [SerializeField] private string description = "Monster's description.";
    [SerializeField] private float HealthPoints;
    [SerializeField] private float MagicPoints;
    public string Name => name;
    public string Description => description;
    public float HP => HealthPoints;
    public float MP => MagicPoints;
}
