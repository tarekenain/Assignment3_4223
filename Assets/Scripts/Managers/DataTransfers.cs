using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataTransfers : MonoBehaviour
{
    public Text PlayerNameText;
    public Text HighScoreText;


    public static string showName;
    public static string showHS;
    
    private void Awake() 
    {
        Debug.Log(DataManager.loadedHS);
        showName = DataManager.PlayerName.ToString();
        PlayerNameText.text = showName;

        showHS = DataManager.loadedHS.ToString();
        HighScoreText.text = showHS;

        Debug.Log(showName + " showhs = " + showHS);
    }

}
