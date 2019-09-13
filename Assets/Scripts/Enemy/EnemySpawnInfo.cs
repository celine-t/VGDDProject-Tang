using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class EnemySpawnInfo
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("name of enemy")]
    private string m_Name;
    public string EnemyName
    {
        get {
            return m_Name;
        }
    }

    [SerializeField]
    [Tooltip("Prefab for spawning")]
    private GameObject m_enemyGO;
    public GameObject EnemyGO
    {
        get { return m_enemyGO;
        }
    }

    [SerializeField]
    [Tooltip("time between spawn")]
    private float m_TimeToNextSpawn;
    public float TimeToNextSpawn
    {
        get { return m_TimeToNextSpawn; }
    }
    [SerializeField]
    [Tooltip("number to spawn")]
    private int m_NumberToSpawn;
    public int NumberToSpawn
    {
        get { return m_NumberToSpawn; }
    }
    #endregion

}
