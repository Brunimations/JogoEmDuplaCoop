using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class boop : MonoBehaviour
{
    public LayerMask layermask;
    public AudioSource somdeboop;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hit, 100.0f))
            {
                if(hit.transform != null)
                {
                    boopado();
                }
            }
        }
    }
    void boopado()
    {
        somdeboop.Play();
    }
}