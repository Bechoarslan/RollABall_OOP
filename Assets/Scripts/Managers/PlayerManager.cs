using System;
using Data.UnityObjects;
using UnityEngine;

namespace Managers
{
    public class PlayerManager : MonoBehaviour
    {

        #region Values

        #region Private Values

        [SerializeField] private PlayerMovementController _movementController;
        private PlayerData _data;
        



        #endregion

        #region Public Values

       



        #endregion

        #endregion


        private void Awake()
        {
            GetPlayerData();
            SendDataToPlayer();
        }


        private void GetPlayerData()
        {
            _data = Resources.Load<CB_PlayerSO>("Data/CB_Player").Data;
        }
        private void OnEnable()
        {
            SubscribeEvent();
        }
        private void SubscribeEvent()
        {
            InputSignals.Instance.OnInputPressed += _movementController.InputValues;
        }
        private void UnSubscribeEvent()
        {
            InputSignals.Instance.OnInputPressed -= _movementController.InputValues;
        }

        private void OnDisable()
        {
            UnSubscribeEvent();
        }

        private void SendDataToPlayer()
        {
            _movementController.SetMovementData(_data.MovementData);
            
        }
       
    }

   
}