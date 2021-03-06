using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandScript : MonoBehaviour
{
    public Transform StandPlace, AttackPlace, ReturnPlace;

    float AttackCd = 3f;
    bool Attacked;

    StandFolow folowScript;

    RotateTo roatateScript;

    public GameObject StandHand;
    
    void Start()
    {
        Attacked = false;
        folowScript = GetComponent<StandFolow>();
        roatateScript= transform.GetChild(0).gameObject.GetComponent<RotateTo>();
    }

    
    void Update()
    {
        if (AttackCd > 0) {
            AttackCd -= Time.deltaTime;
        }
        if (AttackCd < 0) {
            AttackCd = 0;

        }


        if (Input.GetMouseButtonDown(0)&& AttackCd==0) {
            Attack();
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            StopAttack();
            
        }

        if (Attacked) {
            Instantiate(StandHand, transform.position,transform.GetChild(0).rotation*  Quaternion.Euler(90, 0, 0));
        }

    }

    public void Attack() {
        folowScript.Folow(AttackPlace);
        roatateScript.ChangeTarget(AttackPlace.GetChild(0).transform);
        folowScript.SetMs(15);

        Attacked = true;

    }
    public void StopAttack()
    {
       
        if (Attacked)
        {
            folowScript.Folow(StandPlace);
            folowScript.SetMs(14);
            Invoke("StartRotate", 1);
            AttackCd = 3f;
            Attacked = false;
        }
    }
    public void StartRotate() {
        roatateScript.ChangeTarget(ReturnPlace);
    }

}
