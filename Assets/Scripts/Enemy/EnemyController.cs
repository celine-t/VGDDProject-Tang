using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("hp")]
    private int m_MaxHealth;

    [SerializeField]
    [Tooltip("Speed")]
    private int m_Speed;


    [SerializeField]
    [Tooltip("dpf")]
    private int m_Damage;

    [SerializeField]
    [Tooltip("explosion")]
    private ParticleSystem m_DeathExplosion;
   

    [SerializeField]
    [Tooltip("HP drop rate")]
    private float m_HealthPillDropRate;


    [SerializeField]
    [Tooltip("Type of HP drop")]
    private GameObject m_HealthPill;

    [SerializeField]
    [Tooltip("points")]
    private int m_Score;
    #endregion

    #region Private Variable
    private float p_currentHealth;
    #endregion

    #region Cached Components
    private Rigidbody cc_Rb;
    #endregion

    #region Cached References
    private Transform cr_Player;
    #endregion

    #region Initialization
    private void Awake()
    {
        p_currentHealth = m_MaxHealth;

        cc_Rb = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        cr_Player = FindObjectOfType<PlayerController>().transform;

    }
    #endregion

    #region Main Updates
    private void FixedUpdate()
    {
        Vector3 dir = cr_Player.position - transform.position;
        dir.Normalize();
        cc_Rb.MovePosition(cc_Rb.position + dir * m_Speed * Time.fixedDeltaTime);
    }
    #endregion
    #region Collision Methods
    private void OnCollisionStay(Collision collision)
    {
        GameObject other = collision.collider.gameObject;
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().DecreaseHealth(m_Damage);
        }
    }
    #endregion

    #region Health Methods
    public void DecreaseHealth(float amount)
    {
        p_currentHealth -= amount;
        if (p_currentHealth <= 0)
        {
            ScoreManager.singleton.IncreaseScore(m_Score);
            if (Random.value < m_HealthPillDropRate)
            {
                Instantiate(m_HealthPill, transform.position, Quaternion.identity);
            }

            Instantiate(m_DeathExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    #endregion


}
