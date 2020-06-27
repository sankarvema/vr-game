using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    public void RedColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void BlueColor()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void blackColor()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
}
