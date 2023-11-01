using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null; //싱글톤 디자인 // 외부에서 GameManager에 접근할때 이걸 끌어다가 접근
    [SerializeField] private GameObject settingSound;
    [SerializeField] private GameObject creditPanel;
    [SerializeField] private GameObject pausePanel;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnSettingSoundPanel()
    {
        settingSound.SetActive(true);
    }

    public void OffSettingSoundPanel()
    {
        settingSound.SetActive(false);
    }

    public void OnCreditPanel()
    {
        creditPanel.SetActive(true);
    }

    public void OffCreditPanel()
    {
        creditPanel.SetActive(false);
    }
    
    public void OnExitButton()
    {
        Application.Quit();
    }

    public void OnPausePanel()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void OffPausePanel()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GoMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
