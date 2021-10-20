using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandScript : MonoBehaviour
{
    public Transform StandPlace, AttackPlace, ReturnPlace;

    StandFolow folowScript;
    
    void Start()
    {
        folowScript = GetComponent<StandFolow>();
        folowScript.Folow(StandPlace);
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Attack();
        }
        if (Input.GetMouseButtonUp(0))
        {
            StopAttack();
        }

    }

    public void Attack() {
        folowScript.Folow(AttackPlace);
    }
    public void StopAttack()
    {
        folowScript.Folow(StandPlace);
    }

}
