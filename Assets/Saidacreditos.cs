using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saidacreditos : MonoBehaviour
{
    public BoxCollider caixasair3;

    void OnTriggerStay (Collider colisao)
    { 
        if (colisao.gameObject.tag == "Player" || colisao.gameObject.tag == "Player2")
        {
            Sairfase3();
        }
    }
    void Sairfase3()
    {
        SceneManager.LoadScene("créditos"); 
    }
}
