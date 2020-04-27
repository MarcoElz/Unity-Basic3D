using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(0f,0f,-1f) * speed * Time.deltaTime;
    }
}
