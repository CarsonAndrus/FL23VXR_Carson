using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class changeColorTrigger : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
    
    // changes color to cyan when plug is plugged in
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Keys"))
        {
            myMaterial.color = Color.cyan;
        }
        

    }   // returnes color to orignal color
    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Keys"))
        {
            myMaterial.color = Color.white;
        }

    }
}
