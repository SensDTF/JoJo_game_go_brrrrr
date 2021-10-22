using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandFolow : MonoBehaviour
{
    public Transform target; 
    public float moveSpeed = 14.0f; 
  


    public float eps = 0.1f;

    Vector3 Look;


    void Start()
    {
       
    }


    void Update()
    {/*
      // folow with rotation of obj
        transform.LookAt(target);
        if ((target.position - transform.position).magnitude > eps) {
            transform.Translate(0.0f, 0.0f, moveSpeed * Time.deltaTime);
        }
       */
       
        if ((target.position - transform.position).magnitude > eps)
        {
            Look = (target.position - transform.position).normalized;
            transform.Translate(Look * Time.deltaTime * moveSpeed);
        }
    }

    public void Folow(Transform newTarget){
        target = newTarget;
    }

    public void SetMs(float x)
    {
        moveSpeed = x;
    }

}
