using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivationTime : MonoBehaviour
{
    [SerializeField]
    float tempoParaDesativar;
    float tempoTotal;
    bool reactivationCont;
    void Start()
    {

        tempoTotal = Time.time + tempoParaDesativar;

    }

    void FixedUpdate()
    {
        if(reactivationCont)
        {
            reactivationCont = false;
            tempoTotal = Time.time + tempoParaDesativar;
        }
        if(Time.time >= tempoTotal && !reactivationCont)
        {

            deactivate();

        }
        
    }

    void deactivate()
    {
        reactivationCont = true;
        gameObject.SetActive(false);

    }
}
