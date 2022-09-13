using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptcabo1 : MonoBehaviour
{
    public Material[] materialAtual = new Material[0];
    Renderer render;
    public bool ativado = false;

    public void Start()
    {
        render = GetComponent<Renderer>();
        render.enabled = true;
        render.sharedMaterial = materialAtual[0];
    }
    public void ativar()
    {
        ativado = true;
    }
    public void desativar()
    {
        ativado = false;
    }
    public void Update()
    {
        if(ativado == false)
        {
            render.sharedMaterial = materialAtual[0];
        }else
        {
            render.sharedMaterial = materialAtual[1];
        }
        
    }
}
