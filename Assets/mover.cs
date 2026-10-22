using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class mover : MonoBehaviour
{
    public Rigidbody Bolinha;
   
   

    // Update is called once per frame
    void Update()
    {
        Bolinha.AddForce(0, 0, 1);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Bolinha.AddForce(-4, 0, 0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Bolinha.AddForce(4, 0, 0);
        }
        
    }
}
