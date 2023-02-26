using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{

    public InputField PlayerNameInput;
    public Text showPlayerName;
    public static string PlayerName;

    public Slider pinSpeed;
    public static float PlayerSpeed;
    public static float realSpeed;
    public static float speedMult;
    public Text speedText;

    public Dropdown pinColor;

    public Text highScoreText;
    public static string highScore;
    public static int currentScore = 0;

    public static int loadedHS = 0;
    public static int loadedCC;
    
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Menu")
        {
            realSpeed = pinSpeed.value;
            speedMult = realSpeed * 100;
            speedText.text = speedMult.ToString("N0") + "%";
        }

        
        if (Score.newScore > loadedHS)
        {

            highScore = Score.newScore.ToString();

            PlayerPrefs.SetInt("HighScorePP", Score.newScore);
            loadedHS = PlayerPrefs.GetInt("HighScorePP");
            PlayerPrefs.Save();
            Debug.Log(loadedHS.ToString());
        }

        Debug.Log(loadedHS.ToString());
        
    }


    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text; 
        showPlayerName.text = PlayerName;
    }

    public void ShowName()
    {
        showPlayerName.text = PlayerName;
    }


    public void SetSpeed()
    {
        PlayerSpeed = pinSpeed.value;
        speedText.text = PlayerSpeed.ToString();
    }


    public void ChangeColor()
    {
        
        switch(pinColor.value)
        {
            case 0:
                PlayerPrefs.SetInt("ColorCode", 0);
                loadedCC = PlayerPrefs.GetInt("ColorCode");
                PlayerPrefs.Save();
                break;
            case 1:
                PlayerPrefs.SetInt("ColorCode", 1);
                loadedCC = PlayerPrefs.GetInt("ColorCode");
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetInt("ColorCode", 2);
                loadedCC = PlayerPrefs.GetInt("ColorCode");
                PlayerPrefs.Save();
                break;
            default:
                PlayerPrefs.SetInt("ColorCode", 0);
                loadedCC = PlayerPrefs.GetInt("ColorCode");
                PlayerPrefs.Save();
                break;
        }
    } 


    public void ToMainGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void ToStartMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToEndCredits()
    {
        SceneManager.LoadScene("End");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
