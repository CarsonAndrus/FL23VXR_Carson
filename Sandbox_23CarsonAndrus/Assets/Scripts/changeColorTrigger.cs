using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColorTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Lever Entered Trigger.");
        Color randomColorSelect = GetRandomColor();
        GetComponent<Renderer>().material.color = randomColorSelect;

    }



    public Color GetRandomColor()
    {

        return new Color(r: UnityEngine.Random.Range(0f, 1f), g: UnityEngine.Random.Range(0f, 1f), b: UnityEngine.Random.Range(0f, 1f));
    
    
    
    
    }
}
