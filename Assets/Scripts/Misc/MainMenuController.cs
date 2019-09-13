using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{


    [SerializeField]
    [Tooltip("TEXT component")]
    private Text m_HighScore;

    private string m_DefaultHighSchoreText;

    #region Initialization
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        m_DefaultHighSchoreText = m_HighScore.text;
    }
    private void Start()
    {
        UpdateHighSchore();
    }
    #endregion


    #region Play Button Methods
    public void PlayArena()
    {
        SceneManager.LoadScene("Arena");
    }
    #endregion


    #region General Application Button Methods
    public void Quit()
    {
        Application.Quit();
    }
    #endregion

    //highscore
    private void UpdateHighSchore()
    {
        if (PlayerPrefs.HasKey("HS"))
        {
            m_HighScore.text = m_DefaultHighSchoreText.Replace("%S", PlayerPrefs.GetInt("HS").ToString());
        }
        else {
            PlayerPrefs.SetInt("HS", 0);
            m_HighScore.text = m_DefaultHighSchoreText.Replace("%S", "0");
        }
    }
    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HS", 0);
        UpdateHighSchore();
    }
}
