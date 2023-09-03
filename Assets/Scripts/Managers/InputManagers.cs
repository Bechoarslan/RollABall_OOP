using System;
using System.Collections;
using System.Collections.Generic;
using Keys;
using Unity.Mathematics;
using UnityEngine;

public class InputManagers : MonoBehaviour
{
    #region Varibles

    #region Private Variables

    private float2 _inputValues;

    

    #endregion

    #region Public Variables

    

    #endregion

    #endregion

    
    private void Update()
    {
         _inputValues = SetInputValues();
        if (!Input.anyKey)
            return;
        SendInputValues();

    }

    private void SendInputValues()
    {
        InputSignals.Instance.OnInputPressed?.Invoke(new InputParam()
        {
            inputParam =  _inputValues
        });
        
    }
    

    private float2 SetInputValues()
    {
        
        return new float2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw(("Vertical")));
        
    }
    
    
}
