using System;
using Signals;
using Unity.VisualScripting;
using UnityEngine;

namespace Controllers
{
    public class PhysicController : MonoBehaviour
    {
        #region Self Values

        #region Private Values

    

      

        
       



        #endregion

        #region Public Values



        #endregion

        #endregion


        

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);
                SendTriggerActive();
            }
        }

        private void SendTriggerActive()
        {
            DetectionSignal.Instance.OnTriggerActivated?.Invoke();
            
        }
        

       
    }
}
