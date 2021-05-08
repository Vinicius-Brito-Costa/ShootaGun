using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarField : MonoBehaviour
{
    private Transform trans;
    private ParticleSystem.Particle[] Estrelas;
    private float distEstrelaQuadrado;
    private float distVisualEstrelaQuadrado;

    public Color corEstrela;
    public int quantidadeEstrelas = 600;
    public float tamanhoEstrela = .35f;
    public float distEstrela = 60f;
    public float distVisualEstrela = 15f;

    void Start()
    {

        trans = GetComponent<Transform>();
        distEstrelaQuadrado = distEstrela * distEstrela;
        distVisualEstrelaQuadrado = distVisualEstrela * distVisualEstrela;

    }

    private void CriarEstrelas()
    {

        Estrelas = new ParticleSystem.Particle[quantidadeEstrelas];
        for(int i = 0; i < quantidadeEstrelas; i++)
        {

            Estrelas[i].position = Random.insideUnitSphere * distEstrela + trans.position;
            Estrelas[i].startColor = new Color(corEstrela.r, corEstrela.g, corEstrela.b, corEstrela.a);
            Estrelas[i].startSize = tamanhoEstrela;

        }

    } 

    void Update()
    {

        if (Estrelas == null)
        {

            CriarEstrelas();
        }

        for (int i = 0; i < quantidadeEstrelas; i++)
        {

            if((Estrelas[i].position - trans.position).sqrMagnitude > distEstrelaQuadrado)
            {

                Estrelas[i].position = Random.insideUnitSphere.normalized * distEstrela + trans.position;

            }
            if((Estrelas[i].position - trans.position).sqrMagnitude <= distVisualEstrelaQuadrado)
            {

                float porcento = (Estrelas[i].position - trans.position).sqrMagnitude / distVisualEstrelaQuadrado;
                Estrelas[i].startColor = new Color(1, 1, 1, porcento);
                Estrelas[i].startSize = porcento * tamanhoEstrela;

            }

        }
        GetComponent<ParticleSystem>().SetParticles(Estrelas, Estrelas.Length);
    }
}
