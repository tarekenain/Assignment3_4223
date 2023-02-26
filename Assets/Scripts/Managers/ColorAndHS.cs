// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class ColorAndHS : MonoBehaviour
// {

//     public Text highScoreText;
//     public static int highScore;
//     public static int currentScore = 0;
//     public static string HSText;


//     void Update()
//     {
//         if (Score.newScore > currentScore)
//         {
//             SaveHighScore();
//             // HSText = PlayerPrefs.GetInt(loadedHS.ToString());
            
//             Debug.Log(HSText);
//         }
//     }



//     public void SaveHighScore()
//     {

//         PlayerPrefs.SetInt("HighScore", Score.newScore);
//     }

//     public void LoadHighScore()
//     {
//         int loadedHS = PlayerPrefs.GetInt(HighScore);

//     }
// }
