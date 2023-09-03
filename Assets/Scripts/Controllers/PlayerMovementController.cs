using System;
using Keys;
using Managers;
using Unity.Mathematics;
using UnityEngine;


    public class PlayerMovementController : MonoBehaviour
    {
        #region Values

        #region Private Values

        private Rigidbody _rigidbody;
        private float2 inputSpeed;
        private PlayerMovementData _data;

        

        #endregion

        #region Public Values

        [SerializeField] private PlayerManager _playerManager;

        

         

        

        #endregion

        #endregion

        private void Awake()
        {
            GetPlayerReferences();
            
        }
    

       
        private void FixedUpdate()
        {
            PlayerMovement();
        }
        
        public void InputValues(InputParam obj)
        {
            inputSpeed = obj.inputParam;
        }

       

        
       
     


        private void GetPlayerReferences()
        {
            _rigidbody = GetComponent<Rigidbody>();

        }

        private void PlayerMovement()
        {
            _rigidbody.velocity += new Vector3(inputSpeed.x,0f ,inputSpeed.y) * (_data.Speed * Time.fixedDeltaTime);
        }

        public void SetMovementData(PlayerMovementData movementData)
        {
            _data = movementData;

        }


       
    }
