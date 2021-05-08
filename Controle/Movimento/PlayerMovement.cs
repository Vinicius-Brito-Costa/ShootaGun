using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [Header("Velocidade do Movimento: ")]
    [SerializeField]
    float speed = 10f;
    Rigidbody rb;


    [Header("Objetos Externos: ")]
    Controller controle;

    Vector2 move;
    Vector3 p_input;
    Vector3 p_velocity;

    bool contMove = false;
    P_Animation pAnim;

	
	
    void Start()
    {
        leftRight = GetComponentInChildren<playerLeftRight>();
        controle = GetComponent<PlayerControlCreation>().control;
        controle.Gameplay.AnalogLeft.performed += ctx => move = ctx.ReadValue<Vector2>();
        controle.Gameplay.AnalogLeft.canceled += ctx => move = Vector2.zero;

        controle.Gameplay.RightTrigger2.started += ctx => contMove = true;
        controle.Gameplay.RightTrigger2.canceled += ctx => contMove = false;

        rb = GetComponent<Rigidbody>();
        AudioManager.instance.Play("playerHoverSides");
    }


    void Update()
    {
        p_input = new Vector3(move.x, 0f, move.y);
        if(p_input.z+p_input.x == 0)
        {
            pAnim.moving = false;
            AudioManager.instance.volumePitch("playerHoverSides", Mathf.Lerp(AudioManager.instance.volumeCheck("playerHoverSides"), .05f, 2f * Time.deltaTime), 1f);
        }
        else if(p_input.z+p_input.x > 0)
        {
            pAnim.moving = true;
            AudioManager.instance.volumePitch("playerHoverSides",  Mathf.Lerp(AudioManager.instance.volumeCheck("playerHoverSides"), .15f, 1f * Time.deltaTime), 1f);
        }
    }


    void FixedUpdate()
    {
        if(!contMove)
        {
            p_velocity = ((p_input.z * 1.5f) + (p_input.x * 1.5f)) * speed;
        }
        else
        {
            p_velocity = ((p_input.z * 1.5f) + (p_input.x * 1.5f)) * (speed/5);
        }
        Move();

    }

    public void Move()
    {
        rb.velocity = p_velocity;
        anim(rb.velocity);
    }

}
