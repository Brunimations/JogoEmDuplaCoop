using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class padfase2 : MonoBehaviour
{
    void OnTriggerEnter (Collider colisao2)
    { 
        if (colisao2.gameObject.tag == "Player" && colisao2.gameObject.tag == "Player2")
        {
            SceneManager.LoadScene("fase2"); 
        }
    }
}
