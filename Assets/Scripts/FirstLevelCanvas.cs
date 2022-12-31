using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FirstLevelCanvas : Page
{
     [SerializeField] private Button settingsButton;
     [SerializeField] private SettingsCanvas _settingsCanvas;
     [SerializeField] private Button mainButton;
     [SerializeField] private TextMeshProUGUI scoreText;
     [SerializeField] private string scoreBaseText = "SCORE: ";
     [SerializeField] private string scoreFunText;
     
     private int count = 0;
     

     private void Awake()
     {
         settingsButton.onClick.AddListener(() =>
         {
             this.HideCanvas();
             _settingsCanvas.ShowCanvas();
         });

         mainButton.onClick.AddListener(() =>
         {
             count++;
             scoreText.text = scoreBaseText + count;
             if (count == 10)
             {
                 scoreText.text = scoreFunText;
             }
         });
     }
}
