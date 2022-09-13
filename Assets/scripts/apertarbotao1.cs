using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class apertarbotao1 : MonoBehaviour
{
    public BoxCollider caixa;
    public scriptcabo1[] cabo = new scriptcabo1[0];
    public int tamanho;
    public int i=0;
    public AudioSource somdebotao;

    public void Pisado()
    {
        i=0;
        while(i<tamanho){
        cabo[i].ativar();
        i++;
        }    
    }
    public void NaoPisado()
    {
        while(i<tamanho){
        cabo[i].desativar();
        i++;
        }
    }
    void OnTriggerEnter (Collider colisao)
    { 
        somdebotao.Play();
        if (colisao.gameObject.tag == "Player" || colisao.gameObject.tag == "Player2")
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
