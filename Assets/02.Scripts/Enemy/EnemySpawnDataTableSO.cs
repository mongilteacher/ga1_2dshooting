using UnityEngine;

[CreateAssetMenu(fileName = "EnmySpawnDataTableSO", menuName = "Scriptable Objects/EnemySpawnDataTableSO")]
public class EnemySpawnDataTableSO : ScriptableObject
{
    public EnemySpawnData[] Datas;
}