using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public GameObject Ball;
    public GameObject myhand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            Ball.transform.SetParent(myhand.transform);
            Ball.transform.localPosition = myhand.transform.localPosition;
        }
    }
}
