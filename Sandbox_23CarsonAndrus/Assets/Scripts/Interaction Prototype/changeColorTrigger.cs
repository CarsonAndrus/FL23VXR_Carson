using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class changeColorTrigger : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Keys"))
        {
            myMaterial.color = Color.cyan;
        }
        

    }
    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Keys"))
        {
            myMaterial.color = Color.white;
        }

    }
}
