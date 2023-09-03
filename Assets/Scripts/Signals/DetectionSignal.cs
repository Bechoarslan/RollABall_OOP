using System;
using UnityEngine;

namespace Signals
{
    public class DetectionSignal : MonoBehaviour
    {
        #region Singleton

        public static DetectionSignal Instance;

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

        public Action OnTriggerActivated = delegate {  };
    }
}