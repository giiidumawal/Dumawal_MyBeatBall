using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hits = 1;
    public int point = 30;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        hits--;
        if (hits <= 0)
        {
            Destroy(gameObject);
        }
    }
}
