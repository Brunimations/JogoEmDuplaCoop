using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botaoreinicia : MonoBehaviour
{
    void update()
    {
        bool reiniciabotao = Input.GetKeyDown(KeyCode.Space);
        if (reiniciabotao)
        {
            Reinicia2();
        }
    }
    void Reinicia2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
