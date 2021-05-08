using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlCreation : MonoBehaviour
{
    public Controller control;

    void Awake()
    {
        control = new Controller();
    }
    private void OnEnable()
    {
        control.Gameplay.Enable();
    }
    private void OnDisable()
    {
        control.Gameplay.Disable();
    }
}
