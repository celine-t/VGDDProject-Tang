using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Abilityinfo 
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("power of ability")]
    private int m_Power;
    public int Power
    {
        get { return m_Power; }
    }

    [SerializeField]
    [Tooltip("range")]
    private int m_Range;
    public float Range
    {
        get { return m_Range; }
    }
    #endregion
}
