
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class NewBehaviourScript1 : MonoBehaviour
{
   Animator ani;
   

    void Start()
    {
        ani = GetComponent<Animator>();
        
    } 
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
	    float horizontal =Input.GetAxis("Horizontal");
	    Vector3 dir = new Vector3(horizontal,0,vertical);
	    if (dir != Vector3.zero){
		    transform.rotation = Quaternion.LookRotation(dir);
		    transform.Translate(Vector3.forward*1*Time.deltaTime);
		    ani.SetBool("Run",true);
	    }else{
		    ani.SetBool("Run",false);
	    }
      
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "PickUp"){
            Destroy(collision.collider.gameObject);
        }
    }
   
}
