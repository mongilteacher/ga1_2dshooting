using UnityEngine;

[CreateAssetMenu(fileName = "EnmySpawnDataTableSO", menuName = "Scriptable Objects/EnmySpawnDataTableSO")]
public class EnmySpawnDataTableSO : ScriptableObject
{
    public EnemySpawnData[] Datas;
}