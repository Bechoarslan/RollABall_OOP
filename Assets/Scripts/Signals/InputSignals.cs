using System;
using Keys;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;


    public class InputSignals : MonoBehaviour
    {
        #region Singleton
        
        public static InputSignals Instance;
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }
        #endregion


        public Action<InputParam> OnInputPressed = delegate { };
        

        
        
    }
