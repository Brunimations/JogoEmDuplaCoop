using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player1controle : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float velocidade = 3;
    private Vector3 movimento;
    public Animator animator;
    float x;
    float z;

    void Update()
    {
        Controles();
        GiraPersonagem();
    }
    void FixedUpdate()
    {
        Movimento();
    }
    void Controles()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Reinicia2();
        }
        
        x=Input.GetAxisRaw("Horizontal");
        z=Input.GetAxisRaw("Vertical");
        movimento = new Vector3(x,0,z);
        
        if(x != 0 || z != 0){
            animator.SetBool("andando",true);
            animator.SetBool("idle",false);
        }else
        {
            animator.SetBool("andando",false);
            animator.SetBool("idle",true);
        }
    }
    void Reinicia2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
    void GiraPersonagem()
    {
        if(movimento != Vector3.zero)
        {
            var posicaorelativa = (transform.position + movimento) - transform.position;
            var rotacao = Quaternion.LookRotation(posicaorelativa,Vector3.up);
            transform.rotation = rotacao;
        }        
    } 
    void Movimento()
    {
        rb.MovePosition(transform.position + transform.forward * movimento.magnitude * velocidade * Time.deltaTime);
    }
}
