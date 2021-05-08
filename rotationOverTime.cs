using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationOverTime : MonoBehaviour
{
    [SerializeField] float Velocidade;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (Velocidade * Time.deltaTime));
    }
}
