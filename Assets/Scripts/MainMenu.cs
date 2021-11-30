using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public static MainMenu mainMenu;
    void Start(){
    }
    void Update(){}
    public void onePlayer()
    {
        SceneManager.LoadScene("Computer");
        Time.timeScale = 1;
    }
    public void twoPlayer()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
          UnityEditor.EditorApplication.isPlaying = false;
        #endif
          Application.Quit();
    }

}
