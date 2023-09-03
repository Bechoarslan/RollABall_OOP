using System;
using Data.ValueObjects;
using Managers;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

namespace Controllers
{
    public class UIController : MonoBehaviour
    {
        #region Self Variables

        #region Private Variables

        

        

        #endregion

        #region Public Variables

        [SerializeField] private TextMeshProUGUI scoreText;

        private ScoreData _currentScore;



        #endregion

        #endregion


       

        private void Update()
        {
            DisplayText();
          
        }
        
        private void DisplayText()
        {
            scoreText.text = "Score:" + _currentScore.score;


        }

        public void AddScore()
        {
            _currentScore.score++;

        }

        public void GetScoreData(ScoreData uiDataScoreData)
        {
            _currentScore = uiDataScoreData;
        }
    }
}