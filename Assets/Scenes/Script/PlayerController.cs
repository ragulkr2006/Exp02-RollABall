using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    public float Xforce =5.0f;
       public float Zforce =5.0f;
       public float Yforce =100.0f; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float X=0.0f,Y=0.0f,Z=0.0f;
        if(Input.GetKey(KeyCode.A))
        {
            X=X-Xforce;

        }
        if(Input.GetKey(KeyCode.D))
        {
            X=X+Xforce;
        }
        if(Input.GetKey(KeyCode.A))
        {
            Z=Z-Zforce;
        }
        if(Input.GetKey(KeyCode.D))
        {
            Z=Z+Zforce;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Y=Yforce;
        }
        GetComponent<Rigidbody>().AddForce(X,Y,Z);
    }
}
