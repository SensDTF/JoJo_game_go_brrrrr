using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandFolow : MonoBehaviour
{
    public Transform target; 
    public float moveSpeed = 5.0f; 
  


    public float eps = 0.1f;

    


    void Start()
    {
       
    }


    void Update()
    {
        transform.LookAt(target);
        if ((target.position - transform.position).magnitude > eps) {
            transform.Translate(0.0f, 0.0f, moveSpeed * Time.deltaTime);
        }
    }

    public void Folow(Transform newTarget){
        target = newTarget;
    }
}
