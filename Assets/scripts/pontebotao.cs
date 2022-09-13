using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pontebotao : MonoBehaviour
{
    public BoxCollider caixa;
    public plataforma[] ponte = new plataforma[0];
    public int tamanho;
    public int i=0;

    public void Pisado()
    {
        i=0;
        while(i<tamanho){
        ponte[i].Ativo();
        i++;
        }    
    }
    public void NaoPisado()
    {
        while(i<tamanho){
        ponte[i].Desativo();
        i++;
        }
    }
    void OnTriggerEnter (Collider colisao)
    { 
        if (colisao.gameObject.tag == "Player"|| colisao.gameObject.tag == "Player2")
        {
            Pisado();
        }
    }
    void OnTriggerExit (Collider colisao)
    {
        i=0;
        NaoPisado();
    }
}
