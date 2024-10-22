using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.0f;
    
    void Update()
    {
        Vector3 position = transform.position;

        var x = Input.GetAxis("Horizontal");
        
        transform.position += new Vector3(x, 0, 0).normalized * speed * Time.deltaTime;

    }
}
