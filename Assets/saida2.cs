using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saida2 : MonoBehaviour
{
    public BoxCollider caixasair2;

    void OnTriggerStay (Collider colisao)
    { 
        if (colisao.gameObject.tag == "Player" || colisao.gameObject.tag == "Player2")
        {
            Sairfase2();
        }
    }
    void Sairfase2()
    {
        SceneManager.LoadScene("fase2"); 
    }
}
