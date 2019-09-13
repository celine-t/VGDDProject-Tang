using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("main info")]
    protected Abilityinfo m_Info;
    #endregion

    #region Cached Components
    protected ParticleSystem cc_PS;
    #endregion

    private void Awake()
    {
        cc_PS = GetComponent<ParticleSystem>();
    }

    public abstract void Use(Vector3 spawnPos);

}
