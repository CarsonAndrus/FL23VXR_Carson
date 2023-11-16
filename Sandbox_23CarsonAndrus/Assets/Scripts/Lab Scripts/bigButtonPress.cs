using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigButtonPress : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public Vector3 bigScale = new Vector3 (2,2,2);
    public Vector3 smallScale = new Vector3 (1,1,1);






    public void Bigger()
    {
        transform.localScale = bigScale;
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    
    public void ColorGreen()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void ColorRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
