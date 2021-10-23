using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandHandAttack : MonoBehaviour
{

    public int ms=5;
   
    // Start is called before the first frame update
    void Start()
    {
        float x=Random.Range(-2f, 2f);
        float y = Random.Range(-0.5f, 0.5f);
        float z = Random.Range(-1f, 1f);
        transform.Translate(x, 0, z);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(0, 1, 0) * ms * Time.deltaTime);
        Destroy(gameObject,0.5f);
        
    }
}
