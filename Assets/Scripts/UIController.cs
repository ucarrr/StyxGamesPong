using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] SettingsPopup settingsPopup;
    void Start(){
        settingsPopup.Close();
    }
    void Update(){
        if (Input.GetKey("escape"))
        {
            settingsPopup.Open();
            Time.timeScale = 0;
        }
    }
    public void OnOpenSettings(){
        settingsPopup.Open();
        Time.timeScale = 0;
    }
    public void OnCloseSettings(){
        settingsPopup.Close();
        Time.timeScale = 1;
    }
    public void OnOpenMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    { 

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
        Application.Quit();
    }

}
