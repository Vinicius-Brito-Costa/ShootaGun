using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleEvent : MonoBehaviour
{
    [SerializeField] UnityEvent Selecao, Descelecionado;
    void OnMouseEnter() 
    {
        Selecao.Invoke();
    }
    void OnMouseExit()
    {
        Descelecionado.Invoke();
    }
}