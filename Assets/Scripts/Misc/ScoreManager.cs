using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager singleton;

    private int m_CurScore;
    #region Ini
    private void Awake()
    {
        if (singleton == null)
        { singleton = this; }
        else if (singleton != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion
    public void IncreaseScore(int amount)
    {
        m_CurScore += amount;

    }
    private void UpdateHighScore()
    {
        if (!PlayerPrefs.HasKey("HS"))
        {
            PlayerPrefs.SetInt("HS", m_CurScore);
            return;
        }

        int hs = PlayerPrefs.GetInt("HS");
        if (hs < m_CurScore)
        {
            PlayerPrefs.SetInt("HS", m_CurScore);
        }



    }
    
    private void OnDisable()
    {
        UpdateHighScore();
    }
}
