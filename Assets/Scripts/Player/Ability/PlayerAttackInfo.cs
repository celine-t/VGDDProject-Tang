using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAttackInfo 
{
    [SerializeField]
    [Tooltip("Name of attack")]
    private string m_Name;
    public string AttackName
    {
        get {
            return m_Name;
        }
    }

    [SerializeField]
    [Tooltip("button")]
    private string m_button;
    public string Button
    {
        get {
            return m_button;
        }
    }
    [SerializeField]
    [Tooltip("trigger")]
    private string  m_TriggerName;
    public string Trigger
    {
        get
        {
            return m_TriggerName;
        }
    }
    [SerializeField]
    [Tooltip("abilitygo")]
    private GameObject m_AbilityGO;
    public GameObject AbilityGO
    {
        get
        {
            return m_AbilityGO;
        }
    }

    [SerializeField]
    [Tooltip("offset")]
    private Vector3 m_offset;
    public Vector3 Offset
    {
        get
        {
            return m_offset;
        }
    }

    [SerializeField]
    [Tooltip("windup ")]
    private float m_WindupTime;
    public float WindupTime
    {
        get
        {
            return m_WindupTime;
        }
    }

    [SerializeField]
    [Tooltip("FrozenTime ")]
    private float m_FrozenTime;
    public float FrozenTime
    {
        get
        {
            return m_FrozenTime;
        }
    }



    [SerializeField]
    [Tooltip("CD ")]
    private float m_CD;
    public float CD
    {
        get
        {
            return m_CD;
        }
    }


    [SerializeField]
    [Tooltip("HP cost ")]
    private int m_HP;
    public int HP
    {
        get
        {
            return m_HP;
        }
    }


    [SerializeField]
    [Tooltip("color ")]
    private Color m_color;
    public Color AbilityColor
    {
        get
        {
            return m_color;
        }
    }

    public float Cooldown
    {
        get;
        set;
    }

    public void ResetCooldown()
    {
        Cooldown = m_CD;
    }

    public bool IsReady()
    {
        return Cooldown <= 0;

    }
}
