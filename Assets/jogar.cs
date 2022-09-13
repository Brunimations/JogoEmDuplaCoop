using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jogar : MonoBehaviour
{
    public void jogarJogo(){
        SceneManager.LoadScene("SampleScene"); 
    }
    public void voltarmenu(){
        SceneManager.LoadScene("Menu"); 
    }
}
