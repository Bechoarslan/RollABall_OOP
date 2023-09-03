using System;
using Controllers;
using Data.UnityObjects;
using Data.ValueObjects;
using Signals;
using UnityEngine;

namespace Managers
{
    public class UIManager: MonoBehaviour
    {
        #region Self Variables

        #region Private Variables

        private UIData _uiData;

        

        #endregion

        #region Public Variables

        [SerializeField] private UIController uiController;

        #endregion

        #endregion

        private void Awake()
        {
            GetUIControllerData();
            SetDataUIController();
        }


        private void GetUIControllerData()
        {
            _uiData = Resources.Load<CB_UIData>("Data/CB_UI").uiData;

        }
        private void OnEnable()
        {
            SubscribeEvent();
        }
        private void SubscribeEvent()
        {
            DetectionSignal.Instance.OnTriggerActivated += uiController.AddScore;

        }


        private void OnDisable()
        {
            UnSubscribeEvent();
        }
        private void UnSubscribeEvent()
        {
            DetectionSignal.Instance.OnTriggerActivated -= uiController.AddScore;

        }

        private void SetDataUIController()
        {
            uiController.GetScoreData(_uiData.scoreData);
        }
    }
}