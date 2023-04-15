using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1));
   
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
    }
}
